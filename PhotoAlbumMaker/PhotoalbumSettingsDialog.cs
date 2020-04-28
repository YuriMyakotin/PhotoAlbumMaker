using System;
using System.IO;
using System.Windows.Forms;

namespace PhotoAlbumMaker
{
	public partial class PhotoalbumSettingsDialog : Form
	{
		public PhotoAlbumData CurrentPhotoAlbumInfo;
		public bool isNew;

		public PhotoalbumSettingsDialog(string CurrentPath, PhotoAlbumData photoAlbumInfo)
		{
			isNew = CurrentPath.Length == 0;
			InitializeComponent();
			if (!isNew)
			{
				CurrentPhotoAlbumInfo = photoAlbumInfo;
				PhotoAlbumPathTextBox.Text = CurrentPath;
				PhotoAlbumPathTextBox.ReadOnly = true;
				BrowseButton.Enabled = false;
				PhotoAlbumPathTextBox.TabStop = false;
				NameTextBox.Text = photoAlbumInfo.N;
				DescriptionTextBox.Text = photoAlbumInfo.D;
				SlidesSizeEdit.Value = photoAlbumInfo.IS;
				SlidesQualityEdit.Value = photoAlbumInfo.IQ;
				ThumbsSizeEdit.Value = photoAlbumInfo.TS;
				ThumbsQualityEdit.Value = photoAlbumInfo.TQ;
			}
			else Text = "New photo album";
		}

		private void ButtonOK_Click(object sender, EventArgs e)
		{
			if (NameTextBox.Text.Length == 0)
			{
				WarningLabel.Text = "ERROR: site name cannot be empty";
				return;
			}

			if (isNew)
				if (!Directory.Exists(PhotoAlbumPathTextBox.Text))
				{
					WarningLabel.Text = "ERROR: invalid path entered";
					return;
				}

			DialogResult = DialogResult.OK;
		}

		private void BrowseButton_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog FBD = new FolderBrowserDialog())
			{
				FBD.Description = "Select folder for new photo album";
				if (FBD.ShowDialog() != DialogResult.OK) return;
				PhotoAlbumPathTextBox.Text = FBD.SelectedPath;
			}
		}

		private void ImagesSettings_ValueChanged(object sender, EventArgs e)
		{
			if (isNew) return;
			WarningLabel.Text = SlidesSizeEdit.Value != CurrentPhotoAlbumInfo.IS ||
			                    SlidesQualityEdit.Value != CurrentPhotoAlbumInfo.IQ ||
			                    ThumbsSizeEdit.Value != CurrentPhotoAlbumInfo.TS ||
			                    ThumbsQualityEdit.Value != CurrentPhotoAlbumInfo.TQ
				? "WARNING: you changing images size or quality settings on existing photo album.\nRebuilding all slides and thumbs images with new settings can take long time."
				: string.Empty;
		}
	}
}