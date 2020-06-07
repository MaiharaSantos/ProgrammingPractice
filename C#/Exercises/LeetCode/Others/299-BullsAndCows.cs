using System;

public class Solution
{
	public string GetHint(string secret, string guess)
	{
		var sArray = secret.ToCharArray();
		var gArray = guess.ToCharArray();
		var bulls = 0;
		var cows = 0;
		for (var i = 0; i < sArray.Length; i++)
		{
			if (sArray[i] == gArray[i])
			{
				bulls++;
				sArray[i] = 'x';
				gArray[i] = '-';
			}
		}
		for (var i = 0; i < sArray.Length; i++)
		{
			for (var j = 0; j < gArray.Length; j++)
			{
				if (sArray[i] == gArray[j])
				{
					cows++;
					gArray[j] = '-';
					break;
				}
			}

		}
		return (bulls.ToString() + "A" + cows.ToString() + "B");
	}

	public static int Main(string[] args)
	{
		var game = new Solution();
		Console.WriteLine(game.GetHint(args[0], args[1]));

		return 0;
	}
}
