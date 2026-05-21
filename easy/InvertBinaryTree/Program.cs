public class Solution
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    
    public static void Main()
    {
        var tree = new TreeNode(4,
            new TreeNode(2, 
                new TreeNode(1), 
                new TreeNode(3)
            ),
            new TreeNode(7, 
                new TreeNode(6), 
                new TreeNode(9)
            )
        );
        var result = InvertTree(tree);
        
    }

    public static TreeNode InvertTree(TreeNode root)
    {
        if(root == null)
            return null;
                
        var temp = root.left;
        
        root.left = root.right;
        root.right = temp;
        
        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }
}