namespace PhotoAlbumMaker
{
    partial class PhotoFolderPropertiesDialog
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
			this.OkButton = new System.Windows.Forms.Button();
			this.CnclButton = new System.Windows.Forms.Button();
			this.NameBox = new System.Windows.Forms.TextBox();
			this.DescriptionBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkButton.Enabled = false;
			this.OkButton.Location = new System.Drawing.Point(272, 259);
			this.OkButton.Margin = new System.Windows.Forms.Padding(2);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(64, 24);
			this.OkButton.TabIndex = 0;
			this.OkButton.Text = "Ok";
			this.OkButton.UseVisualStyleBackColor = true;
			// 
			// CnclButton
			// 
			this.CnclButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CnclButton.Location = new System.Drawing.Point(340, 259);
			this.CnclButton.Margin = new System.Windows.Forms.Padding(2);
			this.CnclButton.Name = "CnclButton";
			this.CnclButton.Size = new System.Drawing.Size(64, 24);
			this.CnclButton.TabIndex = 1;
			this.CnclButton.Text = "Cancel";
			this.CnclButton.UseVisualStyleBackColor = true;
			// 
			// NameBox
			// 
			this.NameBox.Location = new System.Drawing.Point(6, 24);
			this.NameBox.Margin = new System.Windows.Forms.Padding(2);
			this.NameBox.MaxLength = 255;
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(398, 37);
			this.NameBox.TabIndex = 2;
			this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
			// 
			// DescriptionBox
			// 
			this.DescriptionBox.Location = new System.Drawing.Point(6, 72);
			this.DescriptionBox.Margin = new System.Windows.Forms.Padding(2);
			this.DescriptionBox.Multiline = true;
			this.DescriptionBox.Name = "DescriptionBox";
			this.DescriptionBox.Size = new System.Drawing.Size(398, 180);
			this.DescriptionBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 30);
			this.label1.TabIndex = 4;
			this.label1.Text = "Folder Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 53);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 30);
			this.label2.TabIndex = 5;
			this.label2.Text = "Description:";
			// 
			// PhotoFolderPropertiesDialog
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(411, 289);
			this.ControlBox = false;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DescriptionBox);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.CnclButton);
			this.Controls.Add(this.OkButton);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PhotoFolderPropertiesDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Folder Name and Descripion";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CnclButton;
        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}