using System;

public class QuickUnionUF
{
	private int[] id;
	private int[] size;
	private int N;

	public QuickUnionUF(int length)
	{
		N = length;
		id = new int[N];
		size = new int[N];

		for (var i = 0; i < N; i++)
		{
			id[i] = i;
			size[i] = 1;
		}
	}

	private int Root(int node)
	{
		int root = node;
		while(id[root] != root) {
			
			root = id[root];
		}
		return root;
	}

	public bool Connected(int p, int q)
	{	return (p < N && q < N) && (Root(p) == Root(q));	}

	public void Union(int p, int q)
	{
		if (p < N && q < N)
		{
			var pRoot = Root(p);
			var qRoot = Root(q);
			if (size[pRoot] < size[qRoot])
			{
				id[pRoot] = qRoot
				size[qRoot] += size[pRoot];
			}
			else
			{
				id[qRoot] = pRoot;
				size[pRoot] += size[qRoot];
			}
		}
	}
}

public class TestQuickUnionUF
{
	public static void Main()
	{
		QuickUnionUF uf = new QuickUnionUF(10);

		Console.WriteLine("Connected (1,2): " + ((uf.Connected(1,2) == false) ? "Passed":"Failed"));
		uf.Union(2,3);
		Console.WriteLine("Connected (2,3): " + ((uf.Connected(2,3) == true) ? "Passed":"Failed"));
		uf.Union(4,7);
		uf.Union(1,8);
		uf.Union(1,7);
		uf.Union(2,4);
		Console.WriteLine("Connected (1,4): " + ((uf.Connected(1,4) == true) ? "Passed":"Failed"));
		Console.WriteLine("Connected (8,9): " + ((uf.Connected(8,9) == false) ? "Passed":"Failed"));
		Console.WriteLine("Connected (3,8): " + ((uf.Connected(3,8) == true) ? "Passed":"Failed"));
		Console.WriteLine("Connected (5,9): " + ((uf.Connected(5,9) == false) ? "Passed":"Failed"));
		Console.WriteLine("Connected (10,9): " + ((uf.Connected(10,9) == false) ? "Passed":"Failed"));
	}
}
