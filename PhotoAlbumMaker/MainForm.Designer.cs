namespace PhotoAlbumMaker
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.OpenImagesFilesDialog = new System.Windows.Forms.OpenFileDialog();
			this.FoldersTree = new System.Windows.Forms.TreeView();
			this.FoldersContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.NewFolderContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RenameFolderContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteFolderContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ImagesList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ImagesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AddImageContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteImageContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.EditImageDescriptionContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SetAsFolderThumbContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ViewAsContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewAsIconsContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewAsTilesContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewAsDetailsContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.StatusBarStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this._MainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.siteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PhotoAlbumEditSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FoldersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.RenameFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ImagesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.EditImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SetAsFolderThumbnailMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.viewAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.VideosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.RenameVideoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteVideoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.VideosList = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.VideosContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AddVideoContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RenameVideoContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DeleteVideoContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.FoldersContextMenu.SuspendLayout();
			this.ImagesContextMenu.SuspendLayout();
			this.StatusBarStrip.SuspendLayout();
			this._MainMenuStrip.SuspendLayout();
			this.VideosContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// OpenImagesFilesDialog
			// 
			this.OpenImagesFilesDialog.Filter = "Images|*.jpg";
			this.OpenImagesFilesDialog.Multiselect = true;
			this.OpenImagesFilesDialog.RestoreDirectory = true;
			// 
			// FoldersTree
			// 
			this.FoldersTree.AllowDrop = true;
			this.FoldersTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FoldersTree.ContextMenuStrip = this.FoldersContextMenu;
			this.FoldersTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FoldersTree.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FoldersTree.HideSelection = false;
			this.FoldersTree.LabelEdit = true;
			this.FoldersTree.Location = new System.Drawing.Point(0, 0);
			this.FoldersTree.Name = "FoldersTree";
			this.FoldersTree.Size = new System.Drawing.Size(303, 702);
			this.FoldersTree.TabIndex = 1;
			this.FoldersTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.Folders_ItemDrag);
			this.FoldersTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FoldersTree_AfterSelect);
			this.FoldersTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.Folders_DragDrop);
			this.FoldersTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.Folders_DragEnter);
			this.FoldersTree.DoubleClick += new System.EventHandler(this.RenameFolderMenuClick);
			// 
			// FoldersContextMenu
			// 
			this.FoldersContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.FoldersContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFolderContextMenuItem,
            this.RenameFolderContextMenuItem,
            this.DeleteFolderContextMenuItem});
			this.FoldersContextMenu.Name = "FoldersContextMenu";
			this.FoldersContextMenu.ShowImageMargin = false;
			this.FoldersContextMenu.Size = new System.Drawing.Size(152, 118);
			this.FoldersContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.FoldersContextMenu_Opening);
			// 
			// NewFolderContextMenuItem
			// 
			this.NewFolderContextMenuItem.Name = "NewFolderContextMenuItem";
			this.NewFolderContextMenuItem.Size = new System.Drawing.Size(151, 38);
			this.NewFolderContextMenuItem.Text = "New";
			this.NewFolderContextMenuItem.Click += new System.EventHandler(this.NewFolderMenuClick);
			// 
			// RenameFolderContextMenuItem
			// 
			this.RenameFolderContextMenuItem.Name = "RenameFolderContextMenuItem";
			this.RenameFolderContextMenuItem.Size = new System.Drawing.Size(151, 38);
			this.RenameFolderContextMenuItem.Text = "Rename";
			this.RenameFolderContextMenuItem.Click += new System.EventHandler(this.RenameFolderMenuClick);
			// 
			// DeleteFolderContextMenuItem
			// 
			this.DeleteFolderContextMenuItem.Name = "DeleteFolderContextMenuItem";
			this.DeleteFolderContextMenuItem.Size = new System.Drawing.Size(151, 38);
			this.DeleteFolderContextMenuItem.Text = "Delete";
			this.DeleteFolderContextMenuItem.Click += new System.EventHandler(this.DeleteFolderMenuClick);
			// 
			// ImagesList
			// 
			this.ImagesList.AllowDrop = true;
			this.ImagesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ImagesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3});
			this.ImagesList.ContextMenuStrip = this.ImagesContextMenu;
			this.ImagesList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ImagesList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ImagesList.FullRowSelect = true;
			this.ImagesList.HideSelection = false;
			this.ImagesList.LargeImageList = this.imageList1;
			this.ImagesList.Location = new System.Drawing.Point(0, 0);
			this.ImagesList.Name = "ImagesList";
			this.ImagesList.ShowGroups = false;
			this.ImagesList.ShowItemToolTips = true;
			this.ImagesList.Size = new System.Drawing.Size(975, 459);
			this.ImagesList.SmallImageList = this.imageList1;
			this.ImagesList.TabIndex = 5;
			this.ImagesList.TileSize = new System.Drawing.Size(36, 36);
			this.ImagesList.UseCompatibleStateImageBehavior = false;
			this.ImagesList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ImagesList_ItemDrag);
			this.ImagesList.SelectedIndexChanged += new System.EventHandler(this.ImagesList_SelectedIndexChanged);
			this.ImagesList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImagesList_DragDrop);
			this.ImagesList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImagesList_DragEnter);
			this.ImagesList.DragOver += new System.Windows.Forms.DragEventHandler(this.ImagesList_DragOver);
			this.ImagesList.DoubleClick += new System.EventHandler(this.EditImageMenuItem_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "";
			this.columnHeader1.Width = 330;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Comments";
			this.columnHeader6.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Exif";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 180;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Geotag";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 130;
			// 
			// ImagesContextMenu
			// 
			this.ImagesContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.ImagesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddImageContextMenuItem,
            this.DeleteImageContextMenuItem,
            this.toolStripSeparator1,
            this.EditImageDescriptionContextMenuItem,
            this.SetAsFolderThumbContextMenuItem,
            this.toolStripSeparator2,
            this.ViewAsContextMenuItem});
			this.ImagesContextMenu.Name = "ImagesContextMenu";
			this.ImagesContextMenu.ShowImageMargin = false;
			this.ImagesContextMenu.Size = new System.Drawing.Size(393, 206);
			this.ImagesContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ImagesContextMenu_Opening);
			// 
			// AddImageContextMenuItem
			// 
			this.AddImageContextMenuItem.Name = "AddImageContextMenuItem";
			this.AddImageContextMenuItem.Size = new System.Drawing.Size(392, 38);
			this.AddImageContextMenuItem.Text = "Add";
			this.AddImageContextMenuItem.Click += new System.EventHandler(this.AddImagesMenuClick);
			// 
			// DeleteImageContextMenuItem
			// 
			this.DeleteImageContextMenuItem.Name = "DeleteImageContextMenuItem";
			this.DeleteImageContextMenuItem.Size = new System.Drawing.Size(392, 38);
			this.DeleteImageContextMenuItem.Text = "Delete";
			this.DeleteImageContextMenuItem.Click += new System.EventHandler(this.DeleteImagesMenuClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(389, 6);
			// 
			// EditImageDescriptionContextMenuItem
			// 
			this.EditImageDescriptionContextMenuItem.Name = "EditImageDescriptionContextMenuItem";
			this.EditImageDescriptionContextMenuItem.Size = new System.Drawing.Size(392, 38);
			this.EditImageDescriptionContextMenuItem.Text = "Edit image description";
			this.EditImageDescriptionContextMenuItem.Click += new System.EventHandler(this.EditImageMenuItem_Click);
			// 
			// SetAsFolderThumbContextMenuItem
			// 
			this.SetAsFolderThumbContextMenuItem.Name = "SetAsFolderThumbContextMenuItem";
			this.SetAsFolderThumbContextMenuItem.Size = new System.Drawing.Size(392, 38);
			this.SetAsFolderThumbContextMenuItem.Text = "Set image as folder Thumbnail";
			this.SetAsFolderThumbContextMenuItem.Click += new System.EventHandler(this.SetAsFolderThumbMenuClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(389, 6);
			// 
			// ViewAsContextMenuItem
			// 
			this.ViewAsContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewAsIconsContextMenuItem,
            this.ViewAsTilesContextMenuItem,
            this.ViewAsDetailsContextMenuItem});
			this.ViewAsContextMenuItem.Name = "ViewAsContextMenuItem";
			this.ViewAsContextMenuItem.Size = new System.Drawing.Size(392, 38);
			this.ViewAsContextMenuItem.Text = "View images as";
			// 
			// ViewAsIconsContextMenuItem
			// 
			this.ViewAsIconsContextMenuItem.Name = "ViewAsIconsContextMenuItem";
			this.ViewAsIconsContextMenuItem.Size = new System.Drawing.Size(269, 44);
			this.ViewAsIconsContextMenuItem.Text = "Large Icons";
			this.ViewAsIconsContextMenuItem.Click += new System.EventHandler(this.ItemsListSetLargeIconsView);
			// 
			// ViewAsTilesContextMenuItem
			// 
			this.ViewAsTilesContextMenuItem.Name = "ViewAsTilesContextMenuItem";
			this.ViewAsTilesContextMenuItem.Size = new System.Drawing.Size(269, 44);
			this.ViewAsTilesContextMenuItem.Text = "Tiles";
			this.ViewAsTilesContextMenuItem.Click += new System.EventHandler(this.ItemsListSetTileView);
			// 
			// ViewAsDetailsContextMenuItem
			// 
			this.ViewAsDetailsContextMenuItem.Name = "ViewAsDetailsContextMenuItem";
			this.ViewAsDetailsContextMenuItem.Size = new System.Drawing.Size(269, 44);
			this.ViewAsDetailsContextMenuItem.Text = "Details";
			this.ViewAsDetailsContextMenuItem.Click += new System.EventHandler(this.ItemsListSetDetailsView);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(180, 180);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// StatusBarStrip
			// 
			this.StatusBarStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.StatusBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
			this.StatusBarStrip.Location = new System.Drawing.Point(0, 742);
			this.StatusBarStrip.Name = "StatusBarStrip";
			this.StatusBarStrip.Size = new System.Drawing.Size(1282, 31);
			this.StatusBarStrip.TabIndex = 6;
			this.StatusBarStrip.Text = "statusStrip1";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 19);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 21);
			// 
			// _MainMenuStrip
			// 
			this._MainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this._MainMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
			this._MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteToolStripMenuItem,
            this.FoldersMenuItem,
            this.ImagesMenuItem,
            this.VideosMenuItem});
			this._MainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this._MainMenuStrip.Name = "_MainMenuStrip";
			this._MainMenuStrip.Size = new System.Drawing.Size(1282, 40);
			this._MainMenuStrip.TabIndex = 7;
			this._MainMenuStrip.Text = "menuStrip1";
			// 
			// siteToolStripMenuItem
			// 
			this.siteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem,
            this.PhotoAlbumEditSettingsMenuItem,
            this.toolStripSeparator6,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
			this.siteToolStripMenuItem.Name = "siteToolStripMenuItem";
			this.siteToolStripMenuItem.Size = new System.Drawing.Size(165, 36);
			this.siteToolStripMenuItem.Text = "Photoalbum";
			// 
			// newToolStripMenuItem1
			// 
			this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
			this.newToolStripMenuItem1.Size = new System.Drawing.Size(279, 44);
			this.newToolStripMenuItem1.Text = "New";
			this.newToolStripMenuItem1.Click += new System.EventHandler(this.NewPhotoAlbumMenuClick);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
			// 
			// PhotoAlbumEditSettingsMenuItem
			// 
			this.PhotoAlbumEditSettingsMenuItem.Name = "PhotoAlbumEditSettingsMenuItem";
			this.PhotoAlbumEditSettingsMenuItem.Size = new System.Drawing.Size(279, 44);
			this.PhotoAlbumEditSettingsMenuItem.Text = "Edit settings";
			this.PhotoAlbumEditSettingsMenuItem.Click += new System.EventHandler(this.EditSettingsMenuItem_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(276, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(276, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(279, 44);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
			// 
			// FoldersMenuItem
			// 
			this.FoldersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem2,
            this.RenameFolderMenuItem,
            this.DeleteFolderMenuItem});
			this.FoldersMenuItem.Name = "FoldersMenuItem";
			this.FoldersMenuItem.Size = new System.Drawing.Size(112, 36);
			this.FoldersMenuItem.Text = "Folders";
			// 
			// newToolStripMenuItem2
			// 
			this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
			this.newToolStripMenuItem2.Size = new System.Drawing.Size(235, 44);
			this.newToolStripMenuItem2.Text = "New";
			this.newToolStripMenuItem2.Click += new System.EventHandler(this.NewFolderMenuClick);
			// 
			// RenameFolderMenuItem
			// 
			this.RenameFolderMenuItem.Name = "RenameFolderMenuItem";
			this.RenameFolderMenuItem.Size = new System.Drawing.Size(235, 44);
			this.RenameFolderMenuItem.Text = "Rename";
			this.RenameFolderMenuItem.Click += new System.EventHandler(this.RenameFolderMenuClick);
			// 
			// DeleteFolderMenuItem
			// 
			this.DeleteFolderMenuItem.Name = "DeleteFolderMenuItem";
			this.DeleteFolderMenuItem.Size = new System.Drawing.Size(235, 44);
			this.DeleteFolderMenuItem.Text = "Delete";
			this.DeleteFolderMenuItem.Click += new System.EventHandler(this.DeleteFolderMenuClick);
			// 
			// ImagesMenuItem
			// 
			this.ImagesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.DeleteImageMenuItem,
            this.toolStripSeparator4,
            this.EditImageMenuItem,
            this.SetAsFolderThumbnailMenuItem,
            this.toolStripSeparator5,
            this.viewAsToolStripMenuItem});
			this.ImagesMenuItem.Name = "ImagesMenuItem";
			this.ImagesMenuItem.Size = new System.Drawing.Size(111, 36);
			this.ImagesMenuItem.Text = "Images";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(403, 44);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.AddImagesMenuClick);
			// 
			// DeleteImageMenuItem
			// 
			this.DeleteImageMenuItem.Name = "DeleteImageMenuItem";
			this.DeleteImageMenuItem.Size = new System.Drawing.Size(403, 44);
			this.DeleteImageMenuItem.Text = "Delete";
			this.DeleteImageMenuItem.Click += new System.EventHandler(this.DeleteImagesMenuClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(400, 6);
			// 
			// EditImageMenuItem
			// 
			this.EditImageMenuItem.Name = "EditImageMenuItem";
			this.EditImageMenuItem.Size = new System.Drawing.Size(403, 44);
			this.EditImageMenuItem.Text = "Edit image description";
			this.EditImageMenuItem.Click += new System.EventHandler(this.EditImageMenuItem_Click);
			// 
			// SetAsFolderThumbnailMenuItem
			// 
			this.SetAsFolderThumbnailMenuItem.Name = "SetAsFolderThumbnailMenuItem";
			this.SetAsFolderThumbnailMenuItem.Size = new System.Drawing.Size(403, 44);
			this.SetAsFolderThumbnailMenuItem.Text = "Set as folder Thumbnail";
			this.SetAsFolderThumbnailMenuItem.Click += new System.EventHandler(this.SetAsFolderThumbMenuClick);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(400, 6);
			// 
			// viewAsToolStripMenuItem
			// 
			this.viewAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconsToolStripMenuItem,
            this.tilesToolStripMenuItem,
            this.detailsToolStripMenuItem});
			this.viewAsToolStripMenuItem.Name = "viewAsToolStripMenuItem";
			this.viewAsToolStripMenuItem.Size = new System.Drawing.Size(403, 44);
			this.viewAsToolStripMenuItem.Text = "View images as:";
			// 
			// largeIconsToolStripMenuItem
			// 
			this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
			this.largeIconsToolStripMenuItem.Size = new System.Drawing.Size(269, 44);
			this.largeIconsToolStripMenuItem.Text = "Large Icons";
			this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.ItemsListSetLargeIconsView);
			// 
			// tilesToolStripMenuItem
			// 
			this.tilesToolStripMenuItem.Name = "tilesToolStripMenuItem";
			this.tilesToolStripMenuItem.Size = new System.Drawing.Size(269, 44);
			this.tilesToolStripMenuItem.Text = "Tiles";
			this.tilesToolStripMenuItem.Click += new System.EventHandler(this.ItemsListSetTileView);
			// 
			// detailsToolStripMenuItem
			// 
			this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
			this.detailsToolStripMenuItem.Size = new System.Drawing.Size(269, 44);
			this.detailsToolStripMenuItem.Text = "Details";
			this.detailsToolStripMenuItem.Click += new System.EventHandler(this.ItemsListSetDetailsView);
			// 
			// VideosMenuItem
			// 
			this.VideosMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.RenameVideoMenuItem,
            this.DeleteVideoMenuItem});
			this.VideosMenuItem.Name = "VideosMenuItem";
			this.VideosMenuItem.Size = new System.Drawing.Size(107, 36);
			this.VideosMenuItem.Text = "Videos";
			// 
			// addToolStripMenuItem1
			// 
			this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
			this.addToolStripMenuItem1.Size = new System.Drawing.Size(235, 44);
			this.addToolStripMenuItem1.Text = "Add";
			this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddVideoMenuItemClick);
			// 
			// RenameVideoMenuItem
			// 
			this.RenameVideoMenuItem.Name = "RenameVideoMenuItem";
			this.RenameVideoMenuItem.Size = new System.Drawing.Size(235, 44);
			this.RenameVideoMenuItem.Text = "Rename";
			this.RenameVideoMenuItem.Click += new System.EventHandler(this.RenameVideoMenuItem_Click);
			// 
			// DeleteVideoMenuItem
			// 
			this.DeleteVideoMenuItem.Name = "DeleteVideoMenuItem";
			this.DeleteVideoMenuItem.Size = new System.Drawing.Size(235, 44);
			this.DeleteVideoMenuItem.Text = "Delete";
			this.DeleteVideoMenuItem.Click += new System.EventHandler(this.DeleteVideoMenuItem_Click);
			// 
			// VideosList
			// 
			this.VideosList.AllowDrop = true;
			this.VideosList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.VideosList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
			this.VideosList.ContextMenuStrip = this.VideosContextMenu;
			this.VideosList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VideosList.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VideosList.FullRowSelect = true;
			this.VideosList.HideSelection = false;
			this.VideosList.Location = new System.Drawing.Point(0, 0);
			this.VideosList.Name = "VideosList";
			this.VideosList.ShowGroups = false;
			this.VideosList.Size = new System.Drawing.Size(975, 239);
			this.VideosList.TabIndex = 8;
			this.VideosList.UseCompatibleStateImageBehavior = false;
			this.VideosList.View = System.Windows.Forms.View.Details;
			this.VideosList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.VideosList_ItemDrag);
			this.VideosList.SelectedIndexChanged += new System.EventHandler(this.VideosList_SelectedIndexChanged);
			this.VideosList.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideosList_DragDrop);
			this.VideosList.DragEnter += new System.Windows.Forms.DragEventHandler(this.VideosList_DragEnter);
			this.VideosList.DragOver += new System.Windows.Forms.DragEventHandler(this.VideosList_DragOver);
			this.VideosList.DoubleClick += new System.EventHandler(this.RenameVideoMenuItem_Click);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Video Name";
			this.columnHeader4.Width = 400;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Video File Name";
			this.columnHeader5.Width = 200;
			// 
			// VideosContextMenu
			// 
			this.VideosContextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.VideosContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddVideoContextMenuItem,
            this.RenameVideoContextMenuItem,
            this.DeleteVideoContextMenuItem});
			this.VideosContextMenu.Name = "VideosContextMenu";
			this.VideosContextMenu.ShowImageMargin = false;
			this.VideosContextMenu.Size = new System.Drawing.Size(152, 118);
			this.VideosContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.VideosContextMenu_Opening);
			// 
			// AddVideoContextMenuItem
			// 
			this.AddVideoContextMenuItem.Name = "AddVideoContextMenuItem";
			this.AddVideoContextMenuItem.Size = new System.Drawing.Size(151, 38);
			this.AddVideoContextMenuItem.Text = "Add";
			this.AddVideoContextMenuItem.Click += new System.EventHandler(this.AddVideoMenuItemClick);
			// 
			// RenameVideoContextMenuItem
			// 
			this.RenameVideoContextMenuItem.Name = "RenameVideoContextMenuItem";
			this.RenameVideoContextMenuItem.Size = new System.Drawing.Size(151, 38);
			this.RenameVideoContextMenuItem.Text = "Rename";
			this.RenameVideoContextMenuItem.Click += new System.EventHandler(this.RenameVideoMenuItem_Click);
			// 
			// DeleteVideoContextMenuItem
			// 
			this.DeleteVideoContextMenuItem.Name = "DeleteVideoContextMenuItem";
			this.DeleteVideoContextMenuItem.Size = new System.Drawing.Size(151, 38);
			this.DeleteVideoContextMenuItem.Text = "Delete";
			this.DeleteVideoContextMenuItem.Click += new System.EventHandler(this.DeleteVideoMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 40);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.FoldersTree);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1282, 702);
			this.splitContainer1.SplitterDistance = 303;
			this.splitContainer1.TabIndex = 9;
			this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.ImagesList);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.VideosList);
			this.splitContainer2.Size = new System.Drawing.Size(975, 702);
			this.splitContainer2.SplitterDistance = 459;
			this.splitContainer2.TabIndex = 0;
			this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1282, 773);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.StatusBarStrip);
			this.Controls.Add(this._MainMenuStrip);
			this.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "PhotoAlbum Maker";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.FoldersContextMenu.ResumeLayout(false);
			this.ImagesContextMenu.ResumeLayout(false);
			this.StatusBarStrip.ResumeLayout(false);
			this.StatusBarStrip.PerformLayout();
			this._MainMenuStrip.ResumeLayout(false);
			this._MainMenuStrip.PerformLayout();
			this.VideosContextMenu.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog OpenImagesFilesDialog;
		private System.Windows.Forms.TreeView FoldersTree;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.StatusStrip StatusBarStrip;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.MenuStrip _MainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem VideosMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem PhotoAlbumEditSettingsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem viewAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem largeIconsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem RenameFolderMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DeleteFolderMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
		public System.Windows.Forms.ListView ImagesList;
		public System.Windows.Forms.ListView VideosList;
		public System.Windows.Forms.ColumnHeader columnHeader4;
		public System.Windows.Forms.ColumnHeader columnHeader5;
		public System.Windows.Forms.ToolStripMenuItem FoldersMenuItem;
		public System.Windows.Forms.ToolStripMenuItem ImagesMenuItem;
		public System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem DeleteImageMenuItem;
		public System.Windows.Forms.ToolStripMenuItem SetAsFolderThumbnailMenuItem;
		public System.Windows.Forms.ToolStripMenuItem EditImageMenuItem;
		public System.Windows.Forms.ToolStripMenuItem RenameVideoMenuItem;
		public System.Windows.Forms.ToolStripMenuItem DeleteVideoMenuItem;
		public System.Windows.Forms.ToolStripMenuItem AddVideoContextMenuItem;
		public System.Windows.Forms.ToolStripMenuItem RenameVideoContextMenuItem;
		public System.Windows.Forms.ToolStripMenuItem DeleteVideoContextMenuItem;
		public System.Windows.Forms.ContextMenuStrip VideosContextMenu;
		public System.Windows.Forms.ToolStripMenuItem NewFolderContextMenuItem;
		public System.Windows.Forms.ToolStripMenuItem RenameFolderContextMenuItem;
		public System.Windows.Forms.ToolStripMenuItem DeleteFolderContextMenuItem;
		public System.Windows.Forms.ContextMenuStrip FoldersContextMenu;
		public System.Windows.Forms.ContextMenuStrip ImagesContextMenu;
		public System.Windows.Forms.ToolStripMenuItem ViewAsContextMenuItem;
		public System.Windows.Forms.ToolStripMenuItem ViewAsIconsContextMenuItem;
		public System.Windows.Forms.ToolStripMenuItem ViewAsTilesContextMenuItem;
		public System.Windows.Forms.ToolStripMenuItem ViewAsDetailsContextMenuItem;
		public System.Windows.Forms.ToolStripMenuItem AddImageContextMenuItem;
		public System.Windows.Forms.ToolStripMenuItem DeleteImageContextMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		public System.Windows.Forms.ToolStripMenuItem EditImageDescriptionContextMenuItem;
		public System.Windows.Forms.ToolStripMenuItem SetAsFolderThumbContextMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	}
}

