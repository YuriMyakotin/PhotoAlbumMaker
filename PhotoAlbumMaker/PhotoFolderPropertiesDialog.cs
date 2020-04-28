using System;
using System.Windows.Forms;

namespace PhotoAlbumMaker
{
	public partial class PhotoFolderPropertiesDialog : Form
	{
		public PhotoFolderPropertiesDialog()
		{
			InitializeComponent();
		}

		private void NameBox_TextChanged(object sender, EventArgs e)
		{
			OkButton.Enabled = NameBox.Text.Length != 0;
		}
	}
}