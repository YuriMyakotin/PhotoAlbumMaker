namespace PhotoAlbumMaker
{
    partial class PhotoalbumSettingsDialog
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.DescriptionTextBox = new System.Windows.Forms.TextBox();
			this.SlidesSizeEdit = new System.Windows.Forms.NumericUpDown();
			this.SlidesQualityEdit = new System.Windows.Forms.NumericUpDown();
			this.ThumbsSizeEdit = new System.Windows.Forms.NumericUpDown();
			this.ThumbsQualityEdit = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.PhotoAlbumPathTextBox = new System.Windows.Forms.TextBox();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.ButtonOK = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.WarningLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SlidesSizeEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SlidesQualityEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ThumbsSizeEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ThumbsQualityEdit)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.DescriptionTextBox, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.SlidesSizeEdit, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.SlidesQualityEdit, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.ThumbsSizeEdit, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.ThumbsQualityEdit, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 343);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 168);
			this.label2.TabIndex = 1;
			this.label2.Text = "Description:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 243);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(217, 43);
			this.label3.TabIndex = 2;
			this.label3.Text = "Slides size, pixels:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 286);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(217, 43);
			this.label4.TabIndex = 3;
			this.label4.Text = "Slides JPEG quality:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 329);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(217, 43);
			this.label5.TabIndex = 4;
			this.label5.Text = "Thumbs size, pixels:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(3, 372);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(217, 43);
			this.label6.TabIndex = 5;
			this.label6.Text = "Thumbs JPEG quality:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NameTextBox
			// 
			this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NameTextBox.Location = new System.Drawing.Point(226, 35);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(433, 37);
			this.NameTextBox.TabIndex = 2;
			// 
			// DescriptionTextBox
			// 
			this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DescriptionTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.DescriptionTextBox.Location = new System.Drawing.Point(226, 78);
			this.DescriptionTextBox.MaxLength = 2000;
			this.DescriptionTextBox.Multiline = true;
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.Size = new System.Drawing.Size(433, 162);
			this.DescriptionTextBox.TabIndex = 3;
			// 
			// SlidesSizeEdit
			// 
			this.SlidesSizeEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SlidesSizeEdit.Location = new System.Drawing.Point(226, 246);
			this.SlidesSizeEdit.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
			this.SlidesSizeEdit.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.SlidesSizeEdit.Name = "SlidesSizeEdit";
			this.SlidesSizeEdit.Size = new System.Drawing.Size(120, 37);
			this.SlidesSizeEdit.TabIndex = 4;
			this.SlidesSizeEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.SlidesSizeEdit.Value = new decimal(new int[] {
            960,
            0,
            0,
            0});
			this.SlidesSizeEdit.ValueChanged += new System.EventHandler(this.ImagesSettings_ValueChanged);
			// 
			// SlidesQualityEdit
			// 
			this.SlidesQualityEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SlidesQualityEdit.Location = new System.Drawing.Point(226, 289);
			this.SlidesQualityEdit.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.SlidesQualityEdit.Name = "SlidesQualityEdit";
			this.SlidesQualityEdit.Size = new System.Drawing.Size(120, 37);
			this.SlidesQualityEdit.TabIndex = 5;
			this.SlidesQualityEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.SlidesQualityEdit.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
			this.SlidesQualityEdit.ValueChanged += new System.EventHandler(this.ImagesSettings_ValueChanged);
			// 
			// ThumbsSizeEdit
			// 
			this.ThumbsSizeEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ThumbsSizeEdit.Location = new System.Drawing.Point(226, 332);
			this.ThumbsSizeEdit.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
			this.ThumbsSizeEdit.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.ThumbsSizeEdit.Name = "ThumbsSizeEdit";
			this.ThumbsSizeEdit.Size = new System.Drawing.Size(120, 37);
			this.ThumbsSizeEdit.TabIndex = 6;
			this.ThumbsSizeEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ThumbsSizeEdit.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
			this.ThumbsSizeEdit.ValueChanged += new System.EventHandler(this.ImagesSettings_ValueChanged);
			// 
			// ThumbsQualityEdit
			// 
			this.ThumbsQualityEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ThumbsQualityEdit.Location = new System.Drawing.Point(226, 375);
			this.ThumbsQualityEdit.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.ThumbsQualityEdit.Name = "ThumbsQualityEdit";
			this.ThumbsQualityEdit.Size = new System.Drawing.Size(120, 37);
			this.ThumbsQualityEdit.TabIndex = 7;
			this.ThumbsQualityEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ThumbsQualityEdit.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
			this.ThumbsQualityEdit.ValueChanged += new System.EventHandler(this.ImagesSettings_ValueChanged);
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(217, 32);
			this.label7.TabIndex = 12;
			this.label7.Text = "Path:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.PhotoAlbumPathTextBox);
			this.flowLayoutPanel1.Controls.Add(this.BrowseButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(226, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(438, 26);
			this.flowLayoutPanel1.TabIndex = 13;
			// 
			// SitePathTextBox
			// 
			this.PhotoAlbumPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PhotoAlbumPathTextBox.Location = new System.Drawing.Point(0, 2);
			this.PhotoAlbumPathTextBox.Margin = new System.Windows.Forms.Padding(0, 2, 1, 1);
			this.PhotoAlbumPathTextBox.Name = "PhotoAlbumPathTextBox";
			this.PhotoAlbumPathTextBox.Size = new System.Drawing.Size(356, 37);
			this.PhotoAlbumPathTextBox.TabIndex = 0;
			// 
			// BrowseButton
			// 
			this.BrowseButton.Location = new System.Drawing.Point(357, 1);
			this.BrowseButton.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(76, 24);
			this.BrowseButton.TabIndex = 1;
			this.BrowseButton.Text = "Browse";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// ButtonOK
			// 
			this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonOK.Location = new System.Drawing.Point(536, 428);
			this.ButtonOK.Name = "ButtonOK";
			this.ButtonOK.Size = new System.Drawing.Size(64, 24);
			this.ButtonOK.TabIndex = 8;
			this.ButtonOK.Text = "OK";
			this.ButtonOK.UseVisualStyleBackColor = true;
			this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonCancel.Location = new System.Drawing.Point(600, 428);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(64, 24);
			this.ButtonCancel.TabIndex = 9;
			this.ButtonCancel.Text = "Cancel";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			// 
			// WarningLabel
			// 
			this.WarningLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.WarningLabel.ForeColor = System.Drawing.Color.Red;
			this.WarningLabel.Location = new System.Drawing.Point(0, 346);
			this.WarningLabel.Name = "WarningLabel";
			this.WarningLabel.Size = new System.Drawing.Size(667, 79);
			this.WarningLabel.TabIndex = 1;
			this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SiteSettingsDialog
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.CancelButton = this.ButtonCancel;
			this.ClientSize = new System.Drawing.Size(670, 457);
			this.ControlBox = false;
			this.Controls.Add(this.WarningLabel);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonOK);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SiteSettingsDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Photoalbum Settings";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SlidesSizeEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SlidesQualityEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ThumbsSizeEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ThumbsQualityEdit)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.TextBox DescriptionTextBox;
        public System.Windows.Forms.NumericUpDown SlidesSizeEdit;
        public System.Windows.Forms.NumericUpDown SlidesQualityEdit;
        public System.Windows.Forms.NumericUpDown ThumbsSizeEdit;
        public System.Windows.Forms.NumericUpDown ThumbsQualityEdit;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BrowseButton;
		public System.Windows.Forms.TextBox PhotoAlbumPathTextBox;
	}
}