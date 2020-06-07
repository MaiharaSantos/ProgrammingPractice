using System;

public class Solution
{
  private int[] _coins = new int[]{1,5,10,25};
  public int NumberOfCombinationsOfCoins(int N)
  {
    return ChangeToCoins(N, 3);
  }
  
  private int ChangeToCoins(int N, int index)
  {
    int possibilities = 1;
    if (N < 0 || index > 3)
    {
      return 0;
    }
    for (var i = 1; i <= index; i++)
    {
      var newValue = N - _coins[i];
      while (newValue >= 0)
      {
        possibilities += ChangeToCoins(newValue, i-1);
        newValue -= _coins[i];
      }
    }
    return possibilities;
  }

  public static int Main(string[] args)
  {
  	var obj = new Solution();
  	Console.WriteLine(obj.NumberOfCombinationsOfCoins(int.Parse(args[0])));
  	return 0;
  }
}