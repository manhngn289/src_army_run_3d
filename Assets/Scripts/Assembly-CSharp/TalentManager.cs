using Aluta;

public class TalentManager : Singleton<TalentManager>
{
	public static float AttackTalentCache;

	public static float MaxHpTalentCache;

	public static float BonusDamageTalentCache;

	public static float CriticalRateTalentCache;

	public static float CriticalDamageTalentCache;

	public static float SpecialDamageReductionTalentCache;

	public static float SpecialHpRecoveryTroopsTalentCache;

	public static float SpecialHeadshotChanceTalentCache;

	private void Start()
	{
	}

	public static float GetTalentValue(TalentData talentData)
	{
		return 0f;
	}

	public static void UpdateTalentCache()
	{
	}

	private static float GetTalentValue(TalentType talentType)
	{
		return 0f;
	}

	public static int GetTalentMaxLevel(TalentType talentType)
	{
		return 0;
	}
}
