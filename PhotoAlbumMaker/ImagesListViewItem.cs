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
			SubItems.Add(ImageItem.D);
			SubItems.Add(ImageItem.Cn);
			SubItems.Add(ImageItem.I);
			SubItems.Add(ImageItem.E);
			SubItems.Add(ImageItem.A);
			SubItems.Add(ImageItem.F);
			SubItems.Add(ImageItem.La);
			SubItems.Add(ImageItem.Lo);
			SubItems.Add(ImageItem.Al);
			ToolTipText = ImageItem.N;
			ImageKey = ImageItem.N;
		}
	}
}