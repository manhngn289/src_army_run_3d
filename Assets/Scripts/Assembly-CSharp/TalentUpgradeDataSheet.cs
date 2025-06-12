using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class TalentUpgradeDataSheet
{
	public int level;

	public float attackValue;

	public float maxHP;

	public float damage;

	public float critRate;

	public float critDmg;

	public float energyShield;

	public float hpRecovery;

	public float headShot;

	private static Dictionary<int, TalentUpgradeDataSheet> dictionary;

	public static TalentUpgradeDataSheet FirstValue { get; private set; }

	public static TalentUpgradeDataSheet LastValue { get; private set; }

	public static TalentUpgradeDataSheet Get(int level, DefaultReturnKind defaultReturnKind = DefaultReturnKind.Exception)
	{
		return null;
	}

	public static Dictionary<int, TalentUpgradeDataSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, TalentUpgradeDataSheet> dic)
	{
	}
}
