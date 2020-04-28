using System.Windows.Forms;

namespace PhotoAlbumMaker
{
	public class ImagesListViewItem : ListViewItem
	{
		public ImageInfo ImageData { get; set; }

		public ImagesListViewItem(ImageInfo ImageItem)
		{
			ImageData = ImageItem;
			Name = ImageItem.N;
			Text = ImageItem.N;
			SubItems.Add(ImageItem.C);
			SubItems.Add(ImageItem.E);
			SubItems.Add(ImageItem.G);
			ToolTipText = ImageItem.N;
			ImageKey = ImageItem.N;
		}
	}
}