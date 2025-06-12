using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class TroopStatDataSheet
{
	public int level;

	public float attack;

	public float maxHP;

	public float rewards;

	public int upgradeAttackPrice;

	public int upgradeMaxHpPrice;

	public int upgradeRewardsPrice;

	private static Dictionary<int, TroopStatDataSheet> dictionary;

	public static TroopStatDataSheet FirstValue { get; private set; }

	public static TroopStatDataSheet LastValue { get; private set; }

	public static TroopStatDataSheet Get(int level, DefaultReturnKind defaultReturnKind = DefaultReturnKind.Exception)
	{
		return null;
	}

	public static Dictionary<int, TroopStatDataSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, TroopStatDataSheet> dic)
	{
	}
}
