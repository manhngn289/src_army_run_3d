using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class TalentInfoDataSheet
{
	public int talentType;

	public string description;

	public int maxLevel;

	private static Dictionary<int, TalentInfoDataSheet> dictionary;

	public static TalentInfoDataSheet FirstValue { get; private set; }

	public static TalentInfoDataSheet LastValue { get; private set; }

	public static TalentInfoDataSheet Get(int talentType, DefaultReturnKind defaultReturnKind = DefaultReturnKind.Exception)
	{
		return null;
	}

	public static Dictionary<int, TalentInfoDataSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, TalentInfoDataSheet> dic)
	{
	}
}
