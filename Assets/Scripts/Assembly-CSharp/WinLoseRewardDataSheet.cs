using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class WinLoseRewardDataSheet
{
	public int level;

	public int winCoinReward;

	public int loseCoinReward;

	public int elixirReward;

	public int elixirRewardLose;

	public int coinPerLevel;

	private static Dictionary<int, WinLoseRewardDataSheet> dictionary;

	public static WinLoseRewardDataSheet FirstValue { get; private set; }

	public static WinLoseRewardDataSheet LastValue { get; private set; }

	public static WinLoseRewardDataSheet Get(int level, DefaultReturnKind defaultReturnKind = DefaultReturnKind.Exception)
	{
		return null;
	}

	public static Dictionary<int, WinLoseRewardDataSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, WinLoseRewardDataSheet> dic)
	{
	}
}
