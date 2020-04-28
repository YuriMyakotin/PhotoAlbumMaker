namespace PhotoAlbumMaker
{
	partial class EditImageDescriptionDialog
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
			this.ImageBox = new System.Windows.Forms.PictureBox();
			this.ImageNaneLabel = new System.Windows.Forms.Label();
			this.DescriptionTextBox = new System.Windows.Forms.TextBox();
			this.OkBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ImageBox
			// 
			this.ImageBox.Location = new System.Drawing.Point(12, 53);
			this.ImageBox.Name = "ImageBox";
			this.ImageBox.Size = new System.Drawing.Size(160, 160);
			this.ImageBox.TabIndex = 0;
			this.ImageBox.TabStop = false;
			// 
			// ImageNaneLabel
			// 
			this.ImageNaneLabel.AutoSize = true;
			this.ImageNaneLabel.Location = new System.Drawing.Point(12, 12);
			this.ImageNaneLabel.Name = "ImageNaneLabel";
			this.ImageNaneLabel.Size = new System.Drawing.Size(0, 13);
			this.ImageNaneLabel.TabIndex = 1;
			// 
			// DescriptionTextBox
			// 
			this.DescriptionTextBox.Location = new System.Drawing.Point(193, 6);
			this.DescriptionTextBox.Multiline = true;
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.Size = new System.Drawing.Size(305, 207);
			this.DescriptionTextBox.TabIndex = 2;
			// 
			// OkBtn
			// 
			this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkBtn.Location = new System.Drawing.Point(369, 223);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.Size = new System.Drawing.Size(64, 24);
			this.OkBtn.TabIndex = 3;
			this.OkBtn.Text = "OK";
			this.OkBtn.UseVisualStyleBackColor = true;
			// 
			// CancelBtn
			// 
			this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new System.Drawing.Point(433, 223);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(64, 24);
			this.CancelBtn.TabIndex = 4;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			// 
			// EditImageDescriptionDialog
			// 
			this.AcceptButton = this.OkBtn;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.CancelBtn;
			this.ClientSize = new System.Drawing.Size(509, 253);
			this.ControlBox = false;
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.OkBtn);
			this.Controls.Add(this.DescriptionTextBox);
			this.Controls.Add(this.ImageNaneLabel);
			this.Controls.Add(this.ImageBox);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditImageDescriptionDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Edit image description";
			((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button OkBtn;
		private System.Windows.Forms.Button CancelBtn;
		public System.Windows.Forms.PictureBox ImageBox;
		public System.Windows.Forms.Label ImageNaneLabel;
		public System.Windows.Forms.TextBox DescriptionTextBox;
	}
}