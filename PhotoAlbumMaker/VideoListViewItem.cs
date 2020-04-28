using System.Windows.Forms;

namespace PhotoAlbumMaker
{
	public class VideoListViewItem : ListViewItem
	{
		public VideoInfo V;

		public VideoListViewItem(VideoInfo V)
		{
			this.V = V;
			Name = V.D;
			Text = V.D;
			SubItems.Add(V.N);
		}
	}
}
