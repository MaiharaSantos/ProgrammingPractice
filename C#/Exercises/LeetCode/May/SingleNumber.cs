using System;
using System.Collections.Generic;

public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        var visited = new HashSet<int>();
        var answer = new int[1];
        
        foreach (var n in nums)
        {
            if(visited.Contains(n))
            {
                visited.Remove(n);
            }
            else
            {
                visited.Add(n);
            }
        }

        visited.CopyTo(answer);
        return answer[0];
    }

    public static int Main(string[] args)
    {
        var test = new Solution();
        var testCase = new int[args.Length];
        
        for(var i = 0; i < args.Length; i++)
        {
            testCase[i] = int.Parse(args[i]);
        }
        Console.WriteLine(test.SingleNumber(testCase));
        
        return 0;
    }
}