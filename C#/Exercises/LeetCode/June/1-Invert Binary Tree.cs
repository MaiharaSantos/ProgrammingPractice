using System;
using System.Linq;
using System.Collections.Generic;

/* Definition for a binary tree node.*/
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    public void BuildTree(int[] nodes)
    {
        if (nodes.Length == 0)
        {
            return;
        }
        this.val = nodes[0];
        AddChildren(this, nodes, 0);
    }

    private void AddChildren(TreeNode parent, int[] nodes, int pos)
    {
        var leftPos = (2*pos + 1);
        var rightPos = (2*pos + 2);
        var len = nodes.Length;
        if (leftPos < len)
        {
            var left = new TreeNode(nodes[leftPos]);
            parent.left = left;
            AddChildren(left, nodes, leftPos);
        }
        if (rightPos < len)
        {
            var right = new TreeNode(nodes[rightPos]);
            parent.right = right;
            AddChildren(right, nodes, rightPos);
        }   
    }
}

public class Solution 
{
    public TreeNode InvertTree(TreeNode root) 
    {
        InvertChildren(root);
        return root;
    }
    
    private void InvertChildren(TreeNode parent)
    {
        if(parent == null)  return;
        var aux = parent.right;
        parent. right = parent.left;
        parent.left = aux;
        InvertChildren(parent.right);
        InvertChildren(parent.left);
    }

    public void PrintTree(TreeNode root)
    {
        var nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);
        while(nodes.Count != 0)
        {
            var currNode = nodes.Dequeue();
            if (currNode == null)
            {
                continue;
            }
            Console.Write("{0}, ", currNode.val);
            nodes.Enqueue(currNode.left);
            nodes.Enqueue(currNode.right);
        }
    }
    
    static public void Main(string[] strs)
    {
        var test = new Solution();
        var root = new TreeNode();
        var nodes = (strs[0]).Split(',').Select(n => Convert.ToInt32(n)).ToArray();
        //Option without Linq
        //var nodes = new int[strs.Length];
        // for (var i = 0; i < strs.Length; i++)
        // {
        //     nodes[i] = int.Parse(strs[i]);
        // }
        root.BuildTree(nodes);
        var invertTree = test.InvertTree(root);
        test.PrintTree(invertTree);
    }
}