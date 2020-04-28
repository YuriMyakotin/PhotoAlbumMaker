using System;
using System.IO;
using System.Windows.Forms;

namespace PhotoAlbumMaker
{
	public partial class AddEditVideoDialog : Form
	{
		public AddEditVideoDialog(VideoInfo VI = null)
		{
			InitializeComponent();
			if (VI != null)
			{
				NameTextBox.Text = VI.D;
				FileNameTextBox.Text = VI.N;
				BrowseButton.Enabled = false;
				FileNameTextBox.ReadOnly = true;
				Text = "Edit video name";
			}
		}

		private void OkBtn_Click(object sender, EventArgs e)
		{
			if (NameTextBox.Text.Length == 0 || FileNameTextBox.Text.Length == 0) return;
			DialogResult = DialogResult.OK;
		}

		private void BrowseButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.InitialDirectory = MainForm.ReadCfgString("LastVideosPath");
				dlg.Title = "Select video file";
				dlg.Multiselect = false;
				dlg.Filter = "MPEG 4 files | *.mp4; *.m4v";
				if (dlg.ShowDialog() != DialogResult.OK) return;
				MainForm.SaveCfgData("LastVideosPath", Path.GetDirectoryName(dlg.FileName));
				FileNameTextBox.Text = dlg.FileName;
			}
		}
	}
}