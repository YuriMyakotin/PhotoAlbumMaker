
namespace PhotoAlbumMaker
{
	public class FoldersTreeNode : System.Windows.Forms.TreeNode
	{
		public FolderInfo F;

		public FoldersTreeNode(FolderInfo F)
		{
			this.F = F;
			this.Text = F.N;
		}
	}
}