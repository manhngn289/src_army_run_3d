using System;
using Aluta;

public class PlayerBuffManager : Singleton<PlayerBuffManager>
{
	public const float ATTACK_BUFF_VALUE = 0.2f;

	public const float ATTACK_SPEED_BUFF_VALUE = 0.15f;

	public const float CRITICAL_CHANGE_BUFF_VALUE = 0.2f;

	public const float CRITICAL_DMG_BUFF_VALUE = 2f;

	public const float MAX_HP_BUFF_VALUE = 0.25f;

	public const float DELAY_THROW_ICE_GRENADE = 3f;

	public const float DELAY_THROW_FIRE_GRENADE = 3f;

	public const int BONUS_TROOP_AMOUNT = 2;

	public const float DOUBLE_SHOT_REDUCE_DMG = 0.3f;

	public const float TWIN_SHOT_REDUCE_DMG = 0.3f;

	public const float INCREASE_COLLECT_RANGE_PERCENT = 0.2f;

	public const float TRIPLE_COLLECT_RANGE_AND_GOLD_COLLECTED = 3f;

	public static bool BuffAttack;

	public static bool BuffAttackSpeed;

	public static bool BuffMaxHp;

	public static bool BuffCriticalRate;

	public static bool BuffCriticalDmg;

	public static bool BuffTreasureMap;

	public static bool BuffBonusTroop;

	public static bool BuffIceGrenade;

	public static bool BuffFireGrenade;

	public static bool BuffDoubleShot;

	public static bool BuffTwinShot;

	public static bool BuffTripleCollectRangeAndGoldCollected;

	public static bool BuffIncreaseCollectRangeCollectPercent;

	public static Tuple<bool, float> AttackBuff => null;

	public static Tuple<bool, float> AttackSpeedBuff => null;

	public static Tuple<bool, float> MaxHpBuff => null;

	public static Tuple<bool, float> CriticalChangeBuff => null;

	public static Tuple<bool, float> CriticalDmgBuff => null;

	public static int BonusTroop => 0;

	public static float BuffTripleCollectRangeAndGoldCollectedValue => 0f;

	public static void ResetBuff()
	{
	}

	public static void AttackActive()
	{
	}

	public static void AttackSpeedActive()
	{
	}

	public static void MaxHpActive()
	{
	}

	public static void CriticalChangeActive()
	{
	}

	public static void CriticalDmgActive()
	{
	}

	public static void TreasureMapActive()
	{
	}

	public static void BonusTroopActive()
	{
	}

	public static void IceGrenadeActive()
	{
	}

	public static void FireGrenadeActive()
	{
	}

	public static void DoubleShotActive()
	{
	}

	public static void TwinShotActive()
	{
	}

	public static void TripleCollectRangeAndGoldCollectedActive()
	{
	}

	public static void IncreaseCollectRangeCollectPercentActive()
	{
	}

	private static void ApplyBuffToAllCurrentTroop()
	{
	}
}
