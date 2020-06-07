using System;

public class QuickFindUF
{
	private int count;
	private int[] id;

	public QuickFindUF(int N)
	{
		count = N;
		id = new int[N];
		for (var i = 0; i < N; i++)
		{
			id[i] = i;
		}
	}

	public bool Connected(int p, int q)
	{	return id[p] == id[q];	}

	public void Union(int p, int q)
	{
		if (Connected(p,q))
		{	
			return;
		}

		var pid = id[p];
		var qid = id[q];
		for (var i = 0; i < count; i++)
		{
			if(id[i] == pid)
			{
				id[i] = qid;
			}
		}
	}
}

public class TestQuickFindUF
{
	public static void Main()
	{
		QuickFindUF uf = new QuickFindUF(10);
		uf.Union(0,5);
		Console.WriteLine("Connected(0,5) " + uf.Connected(0,5));
		Console.WriteLine("Connected(5,6) " + uf.Connected(5,6));
		uf.Union(5,6);
		uf.Union(1,2);
		uf.Union(2,7);
		uf.Union(3,4);
		uf.Union(4,8);
		uf.Union(8,9);
		Console.WriteLine("Connected(0,7) " + uf.Connected(0,7));
		Console.WriteLine("Connected(1,2) " + uf.Connected(1,2));
		Console.WriteLine("Connected(3,4) " + uf.Connected(3,4));
		Console.WriteLine("Connected(5,9) " + uf.Connected(5,9));
		Console.WriteLine("Connected(8,9) " + uf.Connected(8,9));
	}
}
