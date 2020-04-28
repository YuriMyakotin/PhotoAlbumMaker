namespace PhotoAlbumMaker
{
	internal class FoldersThumbListItem
	{
		public string Text { get; set; }
		public int ID { get; set; }

		public FoldersThumbListItem(string N, int I)
		{
			Text = N; ID = I;
		}
	}
}