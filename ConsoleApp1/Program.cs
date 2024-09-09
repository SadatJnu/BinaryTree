public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;

	public TreeNode(int value)
	{
		val = value;
		left = null;
		right = null;
	}
}

public class BinaryTree
{
	public List<int> GetRightmostNodes(TreeNode root)
	{
		List<int> result = new List<int>();

		if (root == null)
			return result;

		Queue<TreeNode> queue = new Queue<TreeNode>();
		queue.Enqueue(root);

		while (queue.Count > 0)
		{
			int levelSize = queue.Count;
			TreeNode rightmost = null;

			for (int i = 0; i < levelSize; i++)
			{
				TreeNode current = queue.Dequeue();
				rightmost = current;

				if (current.left != null)
					queue.Enqueue(current.left);

				if (current.right != null)
					queue.Enqueue(current.right);
			}

			if (rightmost != null)
				result.Add(rightmost.val);
		}

		return result;
	}
}

class Program
{
	static void Main(string[] args)
	{
		///////// No. 1
		TreeNode root = new TreeNode(1)
		{
			left = new TreeNode(2)
			{
				left = new TreeNode(4)
			},
			right = new TreeNode(3)
			{
				left = new TreeNode(5)
				{
					right = new TreeNode(7)
				},
				right = new TreeNode(6)
			}
		};

		BinaryTree tree = new BinaryTree();
		List<int> result = tree.GetRightmostNodes(root);

		Console.WriteLine(string.Join(", ", result));  // Output: 1, 3, 6, 7


		///////////// No. 2

		root = null;
		tree = new BinaryTree();
		result = tree.GetRightmostNodes(root);
		Console.WriteLine(string.Join(", ", result));


		///////////// No. 3

		root = new TreeNode(1);
		tree = new BinaryTree();
		result = tree.GetRightmostNodes(root);
		Console.WriteLine(string.Join(", ", result));


		///////////// No. 4

		root = new TreeNode(1)
		{
			left = new TreeNode(2)
			{
				left = new TreeNode(4),
				right = new TreeNode(5)
			},
			right = new TreeNode(3)
			{
				left = new TreeNode(6),
				right = new TreeNode(7)
			}
		};

		tree = new BinaryTree();
		result = tree.GetRightmostNodes(root);

		Console.WriteLine(string.Join(", ", result));

		///////////// No. 5

		root = new TreeNode(1)
		{
			right = new TreeNode(2)
			{
				right = new TreeNode(3)
				{
					right = new TreeNode(4)
				}
			}
		};

		tree = new BinaryTree();
		result = tree.GetRightmostNodes(root);

		Console.WriteLine(string.Join(", ", result));

		///////////// No. 6

		root = new TreeNode(1)
		{
			left = new TreeNode(2)
			{
				left = new TreeNode(3)
				{
					left = new TreeNode(4)
				}
			}
		};

		tree = new BinaryTree();
		result = tree.GetRightmostNodes(root);

		Console.WriteLine(string.Join(", ", result));

		///////////// No. 7

		root = new TreeNode(1)
		{
			left = new TreeNode(2)
			{
				left = new TreeNode(4),
				right = new TreeNode(5)
			},
			right = new TreeNode(3)
			{
				right = new TreeNode(7)
			}
		};

		tree = new BinaryTree();
		result = tree.GetRightmostNodes(root);

		Console.WriteLine(string.Join(", ", result));

		///////////// No. 8

		root = new TreeNode(1)
		{
			left = new TreeNode(2)
			{
				right = new TreeNode(4)
			},
			right = new TreeNode(3)
		};

		tree = new BinaryTree();
		result = tree.GetRightmostNodes(root);

		Console.WriteLine(string.Join(", ", result));




		Console.ReadKey();


	}
}


