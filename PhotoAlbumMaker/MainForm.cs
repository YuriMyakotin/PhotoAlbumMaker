using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExifLib;
using Newtonsoft.Json;

namespace PhotoAlbumMaker
{
	public partial class MainForm : Form
	{
		private string PhotoAlbumPath;
		private int MaxFolderID;
		private PhotoAlbumData _photoAlbumInfo = new PhotoAlbumData();

		private bool LoadComplete = false;

		private int SelectedFolderID;
		private FolderInfo SelectedFolder;
		private static readonly Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

		private static string ExposureToStr(double Exposure) =>
			Exposure > 0.5
				? Exposure.ToString(CultureInfo.InvariantCulture)
				: "1/" + (1 / Exposure).ToString(CultureInfo.InvariantCulture);

		public MainForm()
		{
			InitializeComponent();

			int SizeX = ReadCfgInt("SizeX", 0);
			int SizeY = ReadCfgInt("SizeY", 0);
			bool isMax = (ReadCfgString("Maximized") == "true");
			if ((SizeX!=0)&&(SizeY!=0)) Size=new Size(SizeX,SizeY);
			if (isMax) WindowState = FormWindowState.Maximized;

			SizeX = ReadCfgInt("FoldersWindowWidth", 0);
			SizeY = ReadCfgInt("ImagesWindowHeight", 0);
			if (SizeX != 0)
			{
				splitContainer1.SplitterDistance = SizeX;
			}
			if (SizeY != 0) splitContainer2.SplitterDistance = SizeY;

			LoadComplete = true;
		}

		public static string ReadCfgString(string CfgName)
		{
			string retval = string.Empty;
			try
			{
				retval = config.AppSettings.Settings[CfgName].Value;
			}
			catch { };
			return retval;
		}

		public static int ReadCfgInt(string CfgName, int DefaultValue)
		{
			int retval = DefaultValue;
			try
			{
				retval=int.Parse(config.AppSettings.Settings[CfgName].Value);
			}
			catch{}
			return retval;
		}

		public static void SaveCfgData(string CfgName, string CfgData)
		{
			config.AppSettings.Settings.Remove(CfgName);
			config.AppSettings.Settings.Add(CfgName, CfgData);
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings");
		}


		private void LoadPhotoAlbum()
		{

			using (OpenFileDialog OFD = new OpenFileDialog())
			{
				PhotoAlbumPath = ReadCfgString("LastSitePath");

				OFD.InitialDirectory = PhotoAlbumPath;
				OFD.FileName = "Site.json";
				OFD.Filter = "Photo Album Data|Site.json";
				OFD.Title = "Select existing photo album data";
				if (OFD.ShowDialog() != DialogResult.OK) return;
				PhotoAlbumPath = Path.GetDirectoryName(OFD.FileName);
				_photoAlbumInfo.F.Clear();
				try
				{

					using (StreamReader file = File.OpenText(OFD.FileName))
					{
						JsonSerializer serializer = new JsonSerializer();
						_photoAlbumInfo = (PhotoAlbumData) serializer.Deserialize(file, typeof(PhotoAlbumData));
					}
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message, "Error loading album data", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				SaveCfgData("LastSitePath",PhotoAlbumPath);

			}

			SetMaxFolderID();
			InitFoldersTree();

		}

		private void SetMaxFolderID()
		{
			MaxFolderID = 0;
			for (int i = 0; i < _photoAlbumInfo.F.Count; i++)
				if (_photoAlbumInfo.F[i].I > MaxFolderID) MaxFolderID = _photoAlbumInfo.F[i].I;
		}

		private void MainFormLoad(object sender, EventArgs e)
		{
			ImagesList.Visible = false;
			VideosList.Visible = false;

			FoldersMenuItem.Enabled = false;
			PhotoAlbumEditSettingsMenuItem.Enabled = false;
			ImagesMenuItem.Enabled = false;
			VideosMenuItem.Enabled = false;

			PhotoAlbumPath = ReadCfgString("LastSitePath");
			if (PhotoAlbumPath.Length>0) LoadPhotoAlbum();


		}


		private void LoadFolderItems(FolderInfo F)
		{
			SelectedFolderID = F.I;
			SelectedFolder = F;
			imageList1.Images.Clear();
			ImagesList.TileSize = new Size(_photoAlbumInfo.TS + 4, _photoAlbumInfo.TS + 4);
			ImagesList.Items.Clear();
			VideosList.Items.Clear();
			if (F.I == 0)
			{
				ImagesList.Visible = false;
				VideosList.Visible = false;
				ImagesMenuItem.Enabled = false;
				VideosMenuItem.Enabled = false;
				RenameFolderMenuItem.Enabled = false;
				DeleteFolderMenuItem.Enabled = false;
				return;
			}

			ImagesList.Visible = true;
			VideosList.Visible = true;
			ImagesMenuItem.Enabled = true;
			VideosMenuItem.Enabled = true;
			RenameFolderMenuItem.Enabled = true;
			DeleteFolderMenuItem.Enabled = true;

			Task task = new Task(() => FillImagesListView());
			task.Start();

			VideosList.Visible = true;
			FillVideosListView();
		}

		private static ImageCodecInfo GetEncoderInfo(string mimeType)
		{
			int j;
			ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
			for (j = 0; j < encoders.Length; ++j)
			{
				if (encoders[j].MimeType == mimeType)
					return encoders[j];
			}
			return null;
		}

		private void FillImagesListView()
		{
			int ProcessedImages = 1;

			ImagesList.AutoArrange = false;
			Application.UseWaitCursor = true;
			FoldersTree.Enabled = false;

			ImagesList.Visible = false;


				List<ImageInfo> ImgList = SelectedFolder.Im;
				toolStripProgressBar1.Value = 0;
				int TotalImages = ImgList.Count;
				toolStripProgressBar1.Maximum = TotalImages;

				foreach (ImageInfo Img in ImgList)
				{
					toolStripStatusLabel2.Text = ProcessedImages.ToString() + "/" + TotalImages.ToString();
					using (Bitmap Thumb = new Bitmap(PhotoAlbumPath +"\\"+ SelectedFolderID.ToString() + "\\thumbs\\" + Img.N))
						imageList1.Images.Add(Img.N,Thumb);

					ImagesListViewItem LI = new ImagesListViewItem(Img);
					this.ImagesList.Items.Add(LI);
					++ProcessedImages;
					++(toolStripProgressBar1.Value);
				}


			ImagesList.Visible = true;
			toolStripStatusLabel2.Text = "";
			toolStripProgressBar1.Value = 0;
			FoldersTree.Enabled = true;

			Application.UseWaitCursor = false;
			ImagesList.AutoArrange = true;
			ImagesList.Sorting = SortOrder.None;
			ImagesList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			EnableDisableImagesMenuItems();
		}

		private void FillVideosListView()
		{
			if (SelectedFolder.V.Count != 0)
			{
				foreach (VideoInfo V in SelectedFolder.V)
				{
					VideoListViewItem VI = new VideoListViewItem(V);
					VideosList.Items.Add(VI);
				}
				VideosList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			}
			else VideosList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

			VideosList.Sorting = SortOrder.None;
			EnableDisableVideosMenuItems();
		}


		private void LoadNewImages(string[] Filenames)
		{
			bool isReplaced = false;

			DialogResult Replace = DialogResult.Cancel;
			ImagesList.AutoArrange = false;
			Application.UseWaitCursor = true;
			FoldersTree.Enabled = false;


			System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
			ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/jpeg");

			EncoderParameter SlideEncParameter = new EncoderParameter(myEncoder, (long)_photoAlbumInfo.IQ);
			EncoderParameter ThumbEncParameter = new EncoderParameter(myEncoder, (long)_photoAlbumInfo.TQ);


			EncoderParameters SlideEncoderParameters = new EncoderParameters(1) {Param = {[0] = SlideEncParameter}};
			EncoderParameters ThumbEncoderParameters = new EncoderParameters(1) {Param = {[0] = ThumbEncParameter}};

			int TotalImages = Filenames.Length, ProcessedImages = 1;
			toolStripProgressBar1.Value = 0;
			toolStripProgressBar1.Maximum = TotalImages;


			foreach (string file in Filenames)
			{
				if (Path.GetExtension(file).ToLower() != ".jpg")
					continue; //skip non-jpg


				string ShortName = Path.GetFileName(file);
				toolStripStatusLabel2.Text = ProcessedImages.ToString() + "/" + TotalImages.ToString();

				int SizeX, SizeY, NewSizeX, NewSizeY;
				double ResizeRate;

				string SlideFileName, ThumbFileName;

				List<ImageInfo> ExistingItems = SelectedFolder.Im.Where(p => p.N == ShortName).ToList();
					if (ExistingItems.Count != 0)
					{
						if (Replace == DialogResult.Abort) continue;
						if (Replace != DialogResult.OK)
						{
							using (ReplaceFileDialog rfd = new ReplaceFileDialog())
							{
								rfd.label1.Text = Path.GetFileName(file) + " already exists, replace?";
								Replace = rfd.ShowDialog();

								if ((Replace == DialogResult.Abort) || (Replace == DialogResult.No)) continue;
							}
						}

						// delete existing item
						ImagesList.Items.RemoveByKey(ShortName);
						imageList1.Images.RemoveByKey(ShortName);
						File.Delete(PhotoAlbumPath + "\\" + SelectedFolderID.ToString() + "\\" + ShortName);
						File.Delete(PhotoAlbumPath + "\\" + SelectedFolderID.ToString() + "\\slides\\" + ShortName);
						File.Delete(PhotoAlbumPath + "\\" + SelectedFolderID.ToString() + "\\thumbs\\" + ShortName);

						SelectedFolder.Im.Remove(ExistingItems.First());

						isReplaced = true;
					}

					Bitmap OriginalImage = new Bitmap(file);
					SizeX = OriginalImage.Width;
					SizeY = OriginalImage.Height;

					if (SizeX > SizeY)
					{
						ResizeRate = (double)_photoAlbumInfo.IS / SizeX;
						NewSizeX = _photoAlbumInfo.IS;
						NewSizeY = (int)(SizeY * ResizeRate);
					}
					else
					{
						ResizeRate = (double)_photoAlbumInfo.IS / SizeY;
						NewSizeY = _photoAlbumInfo.IS;
						NewSizeX = (int)(SizeX * ResizeRate);
					}

					Bitmap SlideImage = new Bitmap(NewSizeX, NewSizeY);
					Graphics g = Graphics.FromImage(SlideImage);
					g.CompositingQuality = CompositingQuality.HighQuality;
					g.SmoothingMode = SmoothingMode.HighQuality;
					g.InterpolationMode = InterpolationMode.HighQualityBicubic;
					g.PixelOffsetMode = PixelOffsetMode.HighQuality;
					Rectangle rect = new Rectangle(0, 0, NewSizeX, NewSizeY);
					g.DrawImage(OriginalImage, rect);

					SlideFileName = PhotoAlbumPath + "\\" + SelectedFolderID.ToString() + "\\slides\\" + ShortName;
					SlideImage.Save(SlideFileName, myImageCodecInfo, SlideEncoderParameters);


					if (SizeX < SizeY)
					{
						ResizeRate = (double)_photoAlbumInfo.TS / SizeX;
						NewSizeX = _photoAlbumInfo.TS;
						NewSizeY = (int)(SizeY * ResizeRate);
					}
					else
					{
						ResizeRate = (double)_photoAlbumInfo.TS / SizeY;
						NewSizeY = _photoAlbumInfo.TS;
						NewSizeX = (int)(SizeX * ResizeRate);
					}

					g.Dispose();

					Bitmap TmpImage = new Bitmap(NewSizeX, NewSizeY);
					g = Graphics.FromImage(TmpImage);
					g.CompositingQuality = CompositingQuality.HighQuality;
					g.SmoothingMode = SmoothingMode.HighQuality;
					g.InterpolationMode = InterpolationMode.HighQualityBicubic;
					g.PixelOffsetMode = PixelOffsetMode.HighQuality;
					rect = new Rectangle(0, 0, NewSizeX, NewSizeY);
					g.DrawImage(OriginalImage, rect);

					rect = new Rectangle((NewSizeX - _photoAlbumInfo.TS) / 2, (NewSizeY - _photoAlbumInfo.TS) / 2, _photoAlbumInfo.TS, _photoAlbumInfo.TS);
					Bitmap ThumbImage = TmpImage.Clone(rect, TmpImage.PixelFormat);

					ThumbFileName = PhotoAlbumPath + "\\" + SelectedFolderID.ToString() + "\\thumbs\\" + ShortName;
					ThumbImage.Save(ThumbFileName, myImageCodecInfo, ThumbEncoderParameters);
					SlideImage.Dispose();
					TmpImage.Dispose();
					g.Dispose();
					OriginalImage.Dispose();

					ImageInfo NewImageData = new ImageInfo {N = ShortName,E = string.Empty,G=string.Empty,C=string.Empty};

					try
					{
						bool firstItem = true;
						using (ExifReader reader = new ExifReader(file))
						{
								DateTime dt;
								double? d;
								ushort i;
								string S, S1;

								try
								{
									reader.GetTagValue<DateTime>(ExifTags.DateTime, out dt);
									if (dt.Year >= 1970)
									{
										NewImageData.E = dt.ToString(CultureInfo.InvariantCulture);
										firstItem = false;
									}
								}
								catch { }
								try
								{
									reader.GetTagValue<string>(ExifTags.Make, out S);
									reader.GetTagValue<string>(ExifTags.Model, out S1);
									string Camera = S.Trim() + " " + S1.Trim();
									if (Camera.Length > 0)
									{
										if (!firstItem) NewImageData.E += "; ";
										NewImageData.E += "Camera: "+ Camera;

										firstItem = false;
									}
								}
								catch { }

								try
								{
									reader.GetTagValue<double?>(ExifTags.ExposureTime, out d);
									if (d.HasValue)
									{
										if (!firstItem) NewImageData.E += "; ";
										NewImageData.E += "Exposure time: " + ExposureToStr(d.Value);
										firstItem = false;
									}
								}
								catch { }

								try
								{
									reader.GetTagValue<ushort>(ExifTags.PhotographicSensitivity, out i);
									if (i != 0)
									{
										if (!firstItem) NewImageData.E += "; ";
										NewImageData.E += "ISO: " + i.ToString();
										firstItem = false;
									}
								}
								catch { }


								try
								{

									reader.GetTagValue<Double?>(ExifTags.FNumber, out d);
									if (d.HasValue)
									{

										if (!firstItem) NewImageData.E += "; ";
										NewImageData.E += "Aperture: " + Math.Round((decimal)d.Value, 2).ToString(CultureInfo.InvariantCulture);
										firstItem = false;
									}
								}
								catch { }

								try
								{
									reader.GetTagValue<Double?>(ExifTags.FocalLength, out d);
									if (!firstItem) NewImageData.E += "; ";
									NewImageData.E += "Focal length: " + d.ToString();
								}
								catch { }





								try
								{
									reader.GetTagValue(ExifTags.GPSLatitude, out double[] latitudeDMS);

									reader.GetTagValue(ExifTags.GPSLongitude, out double[] longitudeDMS);

									reader.GetTagValue(ExifTags.GPSLatitudeRef, out string latitudeRef);

									reader.GetTagValue(ExifTags.GPSLongitudeRef, out string longitudeRef);

									// Lat/long are stored as D°M'S" arrays, so you will need to reconstruct their values as below:
									double GPSLatitude = (latitudeRef == "N" ? 1 : -1) *
													(latitudeDMS[0] + latitudeDMS[1] / 60 + latitudeDMS[2] / 3600);

									double GPSLongtitude = (longitudeRef == "E" ? 1 : -1) *
													(longitudeDMS[0] + longitudeDMS[1] / 60 + longitudeDMS[2] / 3600);

									NewImageData.G = GPSLatitude.ToString(CultureInfo.InvariantCulture).Replace(',', '.') + "," + GPSLongtitude.ToString(CultureInfo.InvariantCulture).Replace(',', '.');
								}
								catch { }

						}
					}
					catch { };

					SelectedFolder.Im.Add(NewImageData);
					imageList1.Images.Add(NewImageData.N, ThumbImage);
					ThumbImage.Dispose();
					ImagesListViewItem LI = new ImagesListViewItem(NewImageData);
					ImagesList.Items.Add(LI);
					File.Copy(file, PhotoAlbumPath + "\\" + SelectedFolderID.ToString() + "\\" + ShortName);
					++ProcessedImages;
					++(toolStripProgressBar1.Value);
			}
			toolStripStatusLabel2.Text = "";
			toolStripProgressBar1.Value = 0;
			FoldersTree.Enabled = true;

			SavePhotoAlbumData();
			Application.UseWaitCursor = false;
			ImagesList.AutoArrange = true;



			if (isReplaced)
			{
				LoadFolderItems(SelectedFolder);
			}

			SlideEncoderParameters.Dispose();
			ThumbEncoderParameters.Dispose();
			ThumbEncParameter.Dispose();
			SlideEncParameter.Dispose();
		}



		private void ItemsListSetLargeIconsView(object sender, EventArgs e)
		{
			ImagesList.View = View.LargeIcon;
		}

		private void ItemsListSetDetailsView(object sender, EventArgs e)
		{
			ImagesList.View = View.Details;
			ImagesList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private void ItemsListSetTileView(object sender, EventArgs e)
		{
			ImagesList.View = View.Tile;
		}


		private void ImagesList_DragDrop(object sender, DragEventArgs e)
		{

			if (e.Data.GetDataPresent("FileDrop")) //add files
			{
				string[] s = e.Data.GetData("FileDrop") as string[];
				LoadNewImages(s);
			}
			else
			if (e.Data.GetDataPresent(typeof(List<ImagesListViewItem>)))
			{
				if (!(e.Data.GetData(typeof(List<ImagesListViewItem>)) is List<ImagesListViewItem> DroppedItems)) return;
				int targetIndex = ImagesList.InsertionMark.Index;
				if (targetIndex < 0) targetIndex = 0;

				foreach (ImagesListViewItem LI in DroppedItems)
				{
					int sourceIndex = ImagesList.Items.IndexOf(LI);
					SelectedFolder.Im.RemoveAt(sourceIndex);
					SelectedFolder.Im.Insert(targetIndex,LI.ImageData);
					LI.Remove();
					ImagesList.Items.Insert(targetIndex, LI);
					++targetIndex;
				}
			}

			ImagesList.Alignment = ListViewAlignment.Default;
			ImagesList.Alignment = ListViewAlignment.Top;
			ImagesList.InsertionMark.Index = -1;
			SavePhotoAlbumData();
		}

		private void ImagesList_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void ImagesList_ItemDrag(object sender, ItemDragEventArgs e)
		{
			if (ImagesList.SelectedItems.Count != 0)
			{
				List<ImagesListViewItem> SelectedItems = new List<ImagesListViewItem>();
				foreach (int index in ImagesList.SelectedIndices)
				{
					SelectedItems.Add((ImagesListViewItem)(ImagesList.Items[index]));
				}
				ImagesList.DoDragDrop(SelectedItems, DragDropEffects.Move);
			}
		}

		private void ImagesList_DragOver(object sender, DragEventArgs e)
		{
			Point targetPoint =
		   ImagesList.PointToClient(new Point(e.X, e.Y));

			int targetIndex = ImagesList.InsertionMark.NearestIndex(targetPoint);

			// Confirm that the mouse pointer is not over the dragged item.
			if (targetIndex > -1)
			{
				Rectangle itemBounds = ImagesList.GetItemRect(targetIndex);
				ImagesList.InsertionMark.AppearsAfterItem = targetPoint.X > itemBounds.Left + (itemBounds.Width / 2);
			}

			ImagesList.InsertionMark.Index = targetIndex;
		}

		private void AddImagesMenuClick(object sender, EventArgs e)
		{
			OpenImagesFilesDialog.InitialDirectory = ReadCfgString("LastImagesPath");
			if (OpenImagesFilesDialog.ShowDialog() == DialogResult.OK)
			{
				SaveCfgData("LastImagesPath",Path.GetDirectoryName(OpenImagesFilesDialog.FileNames[0]));
				Task task = new Task(() => LoadNewImages(OpenImagesFilesDialog.FileNames));
				task.Start();
			};
		}

		private void DeleteImagesMenuClick(object sender, EventArgs e)
		{
			if (ImagesList.SelectedItems.Count != 0)
			{
				if (MessageBox.Show("Delete selected images?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) return;
				foreach (ImagesListViewItem LI in ImagesList.SelectedItems)
				{
						SelectedFolder.Im.Remove(LI.ImageData);
						ImagesList.Items.Remove(LI);
						imageList1.Images.RemoveByKey(LI.ImageData.N);
						File.Delete(PhotoAlbumPath + "\\" + SelectedFolderID.ToString() + "\\" + LI.ImageData.N);
						File.Delete(PhotoAlbumPath + "\\" + SelectedFolderID.ToString() + "\\slides\\" + LI.ImageData.N);
						File.Delete(PhotoAlbumPath + "\\" + SelectedFolderID.ToString() + "\\thumbs\\" + LI.ImageData.N);
				}
			}
			SavePhotoAlbumData();
		}


		private void SetAsFolderThumbMenuClick(object sender, EventArgs e)
		{
			if (ImagesList.SelectedItems.Count != 1) return;

			string ThumbName = ((ImagesListViewItem)(ImagesList.SelectedItems[0])).ImageData.N;
			using (SetFolderThumbDialog dlg = new SetFolderThumbDialog())
			{
				dlg.pictureBox1.Image = imageList1.Images[ThumbName];
				dlg.FoldersThumbCheckedListBox.DisplayMember = "Text";
				FoldersTreeNode MT = ((FoldersTreeNode) (FoldersTree.SelectedNode));
				do
				{
					var LI = new FoldersThumbListItem(MT.Text, MT.F.I);
					dlg.FoldersThumbCheckedListBox.Items.Add(LI);
					MT = (FoldersTreeNode) MT.Parent;
				} while (MT.F.I != 0);

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					if (dlg.FoldersThumbCheckedListBox.CheckedItems.Count==0) return;
					foreach (FoldersThumbListItem LI1 in dlg.FoldersThumbCheckedListBox.CheckedItems)
					{
						FolderInfo F = _photoAlbumInfo.F.FirstOrDefault(p => p.I == LI1.ID);
						if (F != null)
						{
							F.TF = SelectedFolder.I;
							F.TN = ThumbName;
						}
					}
					SavePhotoAlbumData();
				}
			}
		}

		private void InitFoldersTree()
		{
			ImagesList.Visible = false;
			VideosList.Visible = false;
			imageList1.ImageSize = new Size(_photoAlbumInfo.TS, _photoAlbumInfo.TS);
			ImagesList.TileSize = new Size(_photoAlbumInfo.TS + 4, _photoAlbumInfo.TS + 4);
			Text = "PhotoAlbum Maker : " + _photoAlbumInfo.N;
			FoldersMenuItem.Enabled = true;
			PhotoAlbumEditSettingsMenuItem.Enabled = true;
			FoldersTreeNode RootNode = new FoldersTreeNode(new FolderInfo { I = 0, PI = 0, N = _photoAlbumInfo.N });
			FoldersTree.Nodes.Clear();
			FoldersTree.Nodes.Add(RootNode);
			FillFoldersTree(RootNode);
			RootNode.ExpandAll();
			FoldersTree.SelectedNode = RootNode;
		}

		private void FillFoldersTree(FoldersTreeNode CurrentNode)
		{
			IEnumerable<FolderInfo> FoldersLst = _photoAlbumInfo.F.Where(p => p.PI == CurrentNode.F.I);

			foreach (FolderInfo p in FoldersLst)
			{
				FoldersTreeNode NewNode = new FoldersTreeNode(p);
				CurrentNode.Nodes.Add(NewNode);
				FillFoldersTree(NewNode);
			}
		}

		private void SaveFoldersTree()
		{
			FoldersTreeNode RootNode = (FoldersTreeNode)FoldersTree.Nodes[0];
			_photoAlbumInfo.F.Clear();
			UpdateFoldersTreeDB(RootNode);
			SavePhotoAlbumData();
		}

		private void UpdateFoldersTreeDB(FoldersTreeNode CurrentNode)
		{
			foreach (FoldersTreeNode node in CurrentNode.Nodes)
			{
				_photoAlbumInfo.F.Add(node.F);
				if (node.Nodes.Count>0) UpdateFoldersTreeDB(node);
			}
		}

		private void Folders_ItemDrag(object sender, ItemDragEventArgs e)
		{
			DoDragDrop(e.Item, DragDropEffects.Move);
		}

		private void Folders_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void Folders_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(FoldersTreeNode)))
			{
				FoldersTreeNode DraggedNode = (FoldersTreeNode)e.Data.GetData(typeof(FoldersTreeNode));
				FoldersTreeNode DestNode = (FoldersTreeNode)((TreeView)sender).GetNodeAt(((TreeView)sender).PointToClient(new Point(e.X, e.Y)));
				if (DestNode == DraggedNode) return;
				if (DraggedNode.F.I == 0) return;
				FoldersTreeNode node1 = DestNode;
				while (true)
				{
					if (node1.F.PI == 0) break;
					if (node1.F.PI == DraggedNode.F.I) return;
					node1 = (FoldersTreeNode)node1.Parent;
				}

				DraggedNode.F.PI = DestNode.F.PI;
				if (((Control.ModifierKeys & Keys.Control) == Keys.Control) || (DestNode.F.I == 0))
				{
					DraggedNode.F.PI = DestNode.F.I;
					DraggedNode.Remove();
					DestNode.Nodes.Insert(DestNode.Index, DraggedNode);
				}
				else
				{
					DraggedNode.F.PI = DestNode.F.PI;
					DraggedNode.Remove();
					DestNode.Parent.Nodes.Insert(DestNode.Index, DraggedNode);
				}
				SaveFoldersTree();
			}
		}

		private void NewFolderMenuClick(object sender, EventArgs e)
		{
			FoldersTreeNode tn = (FoldersTreeNode)FoldersTree.SelectedNode;
			using (PhotoFolderPropertiesDialog dlg = new PhotoFolderPropertiesDialog())
			{
				dlg.Text = "New Folder";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					++MaxFolderID;
					FolderInfo NewFolder = new FolderInfo
					{
						I = MaxFolderID, N = dlg.NameBox.Text, C = dlg.DescriptionBox.Text, PI = tn.F.I
					};
					FoldersTreeNode NewTN = new FoldersTreeNode(NewFolder);
					tn.Nodes.Add(NewTN);
					SaveFoldersTree();
					string DirName = PhotoAlbumPath + "\\" + NewFolder.I.ToString();
					Directory.CreateDirectory(DirName);
					Directory.CreateDirectory(DirName + "\\slides");
					Directory.CreateDirectory(DirName + "\\thumbs");
				}
			}
		}

		private void DeleteFolderMenuClick(object sender, EventArgs e)
		{
			FoldersTreeNode tn = (FoldersTreeNode)FoldersTree.SelectedNode;
			if (tn.F.I == 0) return;
			if (tn.Nodes.Count != 0)
			{
				MessageBox.Show("Cannot delete folder " + tn.Text + " - delete subfolders first", "Delete folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			if (MessageBox.Show("Delete folder " + tn.Text + "?", "Delete folder", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) return;

			_photoAlbumInfo.F.Remove(tn.F);

			string DirName = PhotoAlbumPath + "\\" + tn.F.I.ToString();
			try
			{
				Directory.Delete(DirName, true);
			}
			catch { };
			tn.Remove();

			SavePhotoAlbumData();
			SetMaxFolderID();
		}

		private void RenameFolderMenuClick(object sender, EventArgs e)
		{
			FoldersTreeNode tn = (FoldersTreeNode)FoldersTree.SelectedNode;
			if (tn.F.I == 0) return;
			using (PhotoFolderPropertiesDialog dlg = new PhotoFolderPropertiesDialog())
			{
				dlg.NameBox.Text = tn.Text;
				dlg.DescriptionBox.Text = tn.F.C;


				if (dlg.ShowDialog() == DialogResult.OK)
				{
					tn.F.N = dlg.NameBox.Text;
					tn.F.C = dlg.DescriptionBox.Text;
					tn.Text = dlg.NameBox.Text;
					SavePhotoAlbumData();
				}
			}
		}

		private void FoldersTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			LoadFolderItems(((FoldersTreeNode)(FoldersTree.SelectedNode)).F);
		}


		private void Rebuild(bool isRebuildSlides, bool isRebuildThumbs)
		{
			System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
			ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/jpeg");


			EncoderParameter SlideEncParameter = new EncoderParameter(myEncoder, (long) _photoAlbumInfo.IQ);
			EncoderParameter ThumbEncParameter = new EncoderParameter(myEncoder, (long) _photoAlbumInfo.TQ);


			EncoderParameters SlideEncoderParameters = new EncoderParameters(1) {Param = {[0] = SlideEncParameter}};
			EncoderParameters ThumbEncoderParameters = new EncoderParameters(1) {Param = {[0] = ThumbEncParameter}};

			int ProcessedImages = 0;



			int SizeX, SizeY, NewSizeX, NewSizeY;
			double ResizeRate;

			string SlideFileName, ThumbFileName;

			toolStripProgressBar1.Value = 0;
			toolStripProgressBar1.Maximum = _photoAlbumInfo.TIC;

			foreach (FolderInfo F in _photoAlbumInfo.F)
			{
				string DirName = PhotoAlbumPath + "\\" + F.I.ToString();

				foreach (ImageInfo I in F.Im)
				{

					string OriginalName = DirName + "\\" + I.N;
					Bitmap OriginalImage = new Bitmap(OriginalName);
					ThumbFileName = DirName + "\\thumbs\\" + I.N;
					SlideFileName = DirName + "\\slides\\" + I.N;
					SizeX = OriginalImage.Width;
					SizeY = OriginalImage.Height;

					if (isRebuildSlides)
					{
						File.Delete(SlideFileName);

						if (SizeX > SizeY)
						{
							ResizeRate = (double) _photoAlbumInfo.IS / SizeX;
							NewSizeX = _photoAlbumInfo.IS;
							NewSizeY = (int) (SizeY * ResizeRate);
						}
						else
						{
							ResizeRate = (double) _photoAlbumInfo.IS / SizeY;
							NewSizeY = _photoAlbumInfo.IS;
							NewSizeX = (int) (SizeX * ResizeRate);
						}

						Bitmap SlideImage = new Bitmap(NewSizeX, NewSizeY);
						Graphics g = Graphics.FromImage(SlideImage);
						g.CompositingQuality = CompositingQuality.HighQuality;
						g.SmoothingMode = SmoothingMode.HighQuality;
						g.InterpolationMode = InterpolationMode.HighQualityBicubic;
						g.PixelOffsetMode = PixelOffsetMode.HighQuality;
						Rectangle rect = new Rectangle(0, 0, NewSizeX, NewSizeY);
						g.DrawImage(OriginalImage, rect);


						SlideImage.Save(SlideFileName, myImageCodecInfo, SlideEncoderParameters);
						SlideImage.Dispose();
						g.Dispose();
					}

					if (isRebuildThumbs)
					{
						File.Delete(ThumbFileName);
						if (SizeX < SizeY)
						{
							ResizeRate = (double) _photoAlbumInfo.TS / SizeX;
							NewSizeX = _photoAlbumInfo.TS;
							NewSizeY = (int) (SizeY * ResizeRate);
						}
						else
						{
							ResizeRate = (double) _photoAlbumInfo.TS / SizeY;
							NewSizeY = _photoAlbumInfo.TS;
							NewSizeX = (int) (SizeX * ResizeRate);
						}

						Bitmap TmpImage = new Bitmap(NewSizeX, NewSizeY);
						Graphics g = Graphics.FromImage(TmpImage);
						g.CompositingQuality = CompositingQuality.HighQuality;
						g.SmoothingMode = SmoothingMode.HighQuality;
						g.InterpolationMode = InterpolationMode.HighQualityBicubic;
						g.PixelOffsetMode = PixelOffsetMode.HighQuality;
						Rectangle rect = new Rectangle(0, 0, NewSizeX, NewSizeY);
						g.DrawImage(OriginalImage, rect);

						rect = new Rectangle((NewSizeX - _photoAlbumInfo.TS) / 2, (NewSizeY - _photoAlbumInfo.TS) / 2, _photoAlbumInfo.TS,
							_photoAlbumInfo.TS);
						Bitmap ThumbImage = TmpImage.Clone(rect, TmpImage.PixelFormat);




						ThumbImage.Save(ThumbFileName, myImageCodecInfo, ThumbEncoderParameters);


						TmpImage.Dispose();
						ThumbImage.Dispose();
						g.Dispose();
					}

					OriginalImage.Dispose();

					++ProcessedImages;
					toolStripProgressBar1.Value = ProcessedImages;
					toolStripStatusLabel2.Text = ProcessedImages.ToString() + "/" + _photoAlbumInfo.TIC.ToString();
				}
			}

			SlideEncoderParameters.Dispose();
			ThumbEncoderParameters.Dispose();
			ThumbEncParameter.Dispose();
			SlideEncParameter.Dispose();
		}

		private void SavePhotoAlbumData()
		{
			try
			{
				if (File.Exists(PhotoAlbumPath + "\\Site.json")) File.Copy(PhotoAlbumPath + "\\Site.json", PhotoAlbumPath + "\\Site.json.bak", true);

				_photoAlbumInfo.TIC = 0;
				_photoAlbumInfo.TVC = 0;
				for (int i = 0; i < _photoAlbumInfo.F.Count; i++)
				{
					_photoAlbumInfo.TIC += _photoAlbumInfo.F[i].Im.Count;
					_photoAlbumInfo.TVC += _photoAlbumInfo.F[i].V.Count;
				}
				_photoAlbumInfo.LC = DateTime.Now.ToShortDateString();
				File.WriteAllText(PhotoAlbumPath + "\\Site.json", JsonConvert.SerializeObject(_photoAlbumInfo));
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.Message, "Error saving photo album configuration", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}

		}

		private void EditSettingsMenuItem_Click(object sender, EventArgs e)
		{
			using (PhotoalbumSettingsDialog dlg = new PhotoalbumSettingsDialog(PhotoAlbumPath,_photoAlbumInfo))
			{
				if (dlg.ShowDialog()!=DialogResult.OK) return;
				_photoAlbumInfo.N = dlg.NameTextBox.Text;
				_photoAlbumInfo.D = dlg.DescriptionTextBox.Text;
				bool RebuildSlides = (_photoAlbumInfo.IS != dlg.SlidesSizeEdit.Value) ||
				                     (_photoAlbumInfo.IQ != dlg.SlidesQualityEdit.Value);
				bool RebuildThumbs= (_photoAlbumInfo.TS != dlg.ThumbsSizeEdit.Value) ||
				                    (_photoAlbumInfo.TQ != dlg.ThumbsQualityEdit.Value);

				_photoAlbumInfo.IS = (int)dlg.SlidesSizeEdit.Value;
				_photoAlbumInfo.IQ = (byte)dlg.SlidesQualityEdit.Value;
				_photoAlbumInfo.TS = (int)dlg.ThumbsSizeEdit.Value;
				_photoAlbumInfo.TQ = (byte)dlg.ThumbsQualityEdit.Value;
				SavePhotoAlbumData();

				if (RebuildSlides || RebuildThumbs)
				{
					Task task = new Task(() => Rebuild(RebuildSlides,RebuildThumbs));
					task.Start();
				}
			}
		}

		private void ExitMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OpenMenuItem_Click(object sender, EventArgs e)
		{
			LoadPhotoAlbum();
		}

		private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
		{
			if (!LoadComplete) return;
			SaveCfgData("FoldersWindowWidth",splitContainer1.SplitterDistance.ToString());
		}

		private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
		{
			if (!LoadComplete) return;
			SaveCfgData("ImagesWindowHeight", splitContainer2.SplitterDistance.ToString());
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (!LoadComplete) return;

			if (WindowState ==FormWindowState.Maximized)
			{
				SaveCfgData("Maximized","true");
			}
			else
			{
				SaveCfgData("Maximized","false");
				SaveCfgData("SizeX",Width.ToString());
				SaveCfgData("SizeY",Height.ToString());
			}
		}

		private void VideosList_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(List<VideoListViewItem>)))
			{
				if (!(e.Data.GetData(typeof(List<VideoListViewItem>)) is List<VideoListViewItem> DroppedItems)) return;
				int targetIndex = VideosList.InsertionMark.Index;
				if (targetIndex < 0) targetIndex = 0;

				foreach (VideoListViewItem LI in DroppedItems)
				{
					int sourceIndex = VideosList.Items.IndexOf(LI);
					SelectedFolder.V.RemoveAt(sourceIndex);
					SelectedFolder.V.Insert(targetIndex, LI.V);
					LI.Remove();
					VideosList.Items.Insert(targetIndex, LI);
					++targetIndex;
				}
			}

			VideosList.InsertionMark.Index = -1;
			SavePhotoAlbumData();
		}

		private void VideosList_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void VideosList_DragOver(object sender, DragEventArgs e)
		{

			Point targetPoint =
				VideosList.PointToClient(new Point(e.X, e.Y));

			int targetIndex = VideosList.InsertionMark.NearestIndex(targetPoint);


			if (targetIndex > -1)
			{
				Rectangle itemBounds = VideosList.GetItemRect(targetIndex);
				VideosList.InsertionMark.AppearsAfterItem = targetPoint.X > itemBounds.Left + (itemBounds.Width / 2);
			}

			VideosList.InsertionMark.Index = targetIndex;
		}

		private void VideosList_SelectedIndexChanged(object sender, EventArgs e)
		{
			EnableDisableVideosMenuItems();
		}

		private void ImagesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			EnableDisableImagesMenuItems();
		}

		private void EnableDisableImagesMenuItems()
		{
			EditImageMenuItem.Enabled = (ImagesList.SelectedItems.Count == 1);
			SetAsFolderThumbnailMenuItem.Enabled = (ImagesList.SelectedItems.Count == 1);
			DeleteImageMenuItem.Enabled = (ImagesList.SelectedItems.Count > 0);
		}

		private void EnableDisableVideosMenuItems()
		{
			RenameVideoMenuItem.Enabled = (VideosList.SelectedItems.Count == 1);
			DeleteVideoMenuItem.Enabled = (VideosList.SelectedItems.Count > 0);
		}

		private void NewPhotoAlbumMenuClick(object sender, EventArgs e)
		{
			using (PhotoalbumSettingsDialog dlg = new PhotoalbumSettingsDialog(string.Empty,null))
			{
				if (dlg.ShowDialog() != DialogResult.OK) return;
				PhotoAlbumPath = dlg.PhotoAlbumPathTextBox.Text;
				_photoAlbumInfo = new PhotoAlbumData
				{
					N = dlg.NameTextBox.Text,
					D = dlg.DescriptionTextBox.Text,
					IS = (int) dlg.SlidesSizeEdit.Value,
					IQ = (byte) dlg.SlidesQualityEdit.Value,
					TS = (int) dlg.ThumbsSizeEdit.Value,
					TQ = (byte) dlg.ThumbsQualityEdit.Value
				};
				MaxFolderID = 0;
				try
				{
					Directory.CreateDirectory(PhotoAlbumPath + "\\Videos");
					ZipFile.ExtractToDirectory(AppDomain.CurrentDomain.BaseDirectory+"Website.zip", PhotoAlbumPath);
					SavePhotoAlbumData();
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message, "Error creating new photo album", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					return;
				}

				InitFoldersTree();
			}
		}

		private void AddVideoMenuItemClick(object sender, EventArgs e)
		{
			using (AddEditVideoDialog dlg = new AddEditVideoDialog())
			{
				if (dlg.ShowDialog() != DialogResult.OK) return;
				string FullName = dlg.FileNameTextBox.Text;
				string ShortName = Path.GetFileName(FullName);

				VideoInfo V = new VideoInfo {N = Path.GetFileName(ShortName), D = dlg.NameTextBox.Text};
				try
				{
					File.Copy(FullName, PhotoAlbumPath + "\\videos\\" + ShortName);
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message, "Error adding video", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				SelectedFolder.V.Add(V);
				VideoListViewItem VI = new VideoListViewItem(V);
				VideosList.Items.Add(VI);
				SavePhotoAlbumData();
			}
		}

		private void RenameVideoMenuItem_Click(object sender, EventArgs e)
		{
			if (VideosList.SelectedItems.Count != 1) return;

			VideoInfo V = ((VideoListViewItem) (VideosList.SelectedItems[0])).V;

			using (AddEditVideoDialog dlg = new AddEditVideoDialog(V))
			{
				if (dlg.ShowDialog() != DialogResult.OK) return;
				V.D = dlg.NameTextBox.Text;
				((VideoListViewItem) (VideosList.SelectedItems[0])).Name = V.D;
				((VideoListViewItem)(VideosList.SelectedItems[0])).Text = V.D;
				SavePhotoAlbumData();
			}
		}

		private void DeleteVideoMenuItem_Click(object sender, EventArgs e)
		{
			if (VideosList.SelectedItems.Count != 0)
			{
				if (MessageBox.Show("Delete selected videos?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) return;
				foreach (VideoListViewItem VI in VideosList.SelectedItems)
				{
					SelectedFolder.V.Remove(VI.V);
					VideosList.Items.Remove(VI);
					File.Delete(PhotoAlbumPath + "\\videos\\" +VI.V.N);
				}
			}
			SavePhotoAlbumData();
		}

		private void VideosList_ItemDrag(object sender, ItemDragEventArgs e)
		{
			if (VideosList.SelectedItems.Count != 0)
			{
				List<VideoListViewItem> SelectedItems = new List<VideoListViewItem>();
				foreach (int index in VideosList.SelectedIndices)
				{
					SelectedItems.Add((VideoListViewItem)(VideosList.Items[index]));
				}
				VideosList.DoDragDrop(SelectedItems, DragDropEffects.Move);
			}
		}

		private void EditImageMenuItem_Click(object sender, EventArgs e)
		{
			if (ImagesList.SelectedItems.Count != 1) return;
			using (EditImageDescriptionDialog dlg = new EditImageDescriptionDialog())
			{
				ImageInfo I = ((ImagesListViewItem) (ImagesList.SelectedItems[0])).ImageData;
				dlg.DescriptionTextBox.Text = I.C;
				dlg.ImageBox.Image = imageList1.Images[I.N];
				dlg.ImageNaneLabel.Text = I.N;
				if (dlg.ShowDialog() != DialogResult.OK) return;
				I.C = dlg.DescriptionTextBox.Text;
				SavePhotoAlbumData();

			}
		}

		private void VideosContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			RenameVideoContextMenuItem.Enabled = (VideosList.SelectedItems.Count == 1);
			DeleteVideoContextMenuItem.Enabled = (VideosList.SelectedItems.Count >0);
		}

		private void FoldersContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			RenameFolderContextMenuItem.Enabled = (SelectedFolderID != 0);
			DeleteFolderContextMenuItem.Enabled = (SelectedFolderID != 0);
		}

		private void ImagesContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			DeleteImageContextMenuItem.Enabled = (ImagesList.SelectedItems.Count > 0);
			SetAsFolderThumbContextMenuItem.Enabled= (ImagesList.SelectedItems.Count == 1);
			EditImageDescriptionContextMenuItem.Enabled= (ImagesList.SelectedItems.Count == 1);
		}

		private void AboutMenuItemClick(object sender, EventArgs e)
		{
			using (AboutWindow AW = new AboutWindow())
			{
				AW.ShowDialog();
			}
		}
	}
}