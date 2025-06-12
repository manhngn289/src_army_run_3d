using System;
using Aluta;
using UnityEngine;
using UnityEngine.Serialization;

public class UnitStatInfo : MonoBehaviour
{
	public bool useSheetData;

	public UnitType unitType;

	[SerializeField]
	private UnitController controller;

	[SerializeField]
	private UnitAttack attack;

	[SerializeField]
	private UnitHealth health;

	[SerializeField]
	private UnitMovement movement;

	[SerializeField]
	[ReadOnly]
	[Header("Stat")]
	private float hp;

	[SerializeField]
	[ReadOnly]
	private float atk;

	[SerializeField]
	[ReadOnly]
	private float atkSp;

	[SerializeField]
	[ReadOnly]
	private float crit;

	[SerializeField]
	[ReadOnly]
	private float critDmg;

	[ReadOnly]
	[SerializeField]
	private float attackRange;

	[Space(5f)]
	[Header("CurrentStat")]
	[ReadOnly]
	[SerializeField]
	private float currentHp;

	[SerializeField]
	[ReadOnly]
	private float currentAtk;

	[SerializeField]
	[ReadOnly]
	private float currentAtkSp;

	[ReadOnly]
	[SerializeField]
	private float currentCrit;

	[ReadOnly]
	[SerializeField]
	private float currentCritDmg;

	[Header("Buff")]
	[ReadOnly]
	[SerializeField]
	[Space(5f)]
	private float currentBuffHp;

	[ReadOnly]
	[SerializeField]
	private float currentBuffAtk;

	[SerializeField]
	[ReadOnly]
	private float currentBuffAtkSp;

	[ReadOnly]
	[SerializeField]
	private float currentBuffCritical;

	[SerializeField]
	[ReadOnly]
	private float currentBuffCriticalDmg;

	[ReadOnly]
	[SerializeField]
	[Space(5f)]
	[Header("DeBuff")]
	private float currentDeBuffAtkSp;

	[Space(5f)]
	[Header("Level Buff")]
	[ReadOnly]
	[SerializeField]
	private bool lvBuffAttackDebug;

	[SerializeField]
	[ReadOnly]
	private bool lvBuffAttackSpeedDebug;

	[ReadOnly]
	[SerializeField]
	private bool lvBuffMaxHpDebug;

	[SerializeField]
	[ReadOnly]
	private bool lvBuffCriticalChangeDebug;

	[SerializeField]
	[ReadOnly]
	private bool lvBuffCriticalDmgDebug;

	[SerializeField]
	[ReadOnly]
	private bool lvBuffTreasureMapDebug;

	[ReadOnly]
	[SerializeField]
	private bool lvBuffBonusTroopDebug;

	[ReadOnly]
	[SerializeField]
	private bool lvBuffIceGrenadeDebug;

	[SerializeField]
	[ReadOnly]
	private bool lvBuffFireGrenadeDebug;

	[SerializeField]
	[ReadOnly]
	private bool lvBuffDoubleShotDebug;

	[ReadOnly]
	[SerializeField]
	private bool lvBuffTwinShotDebug;

	[Space(5f)]
	[Header("Level Buff")]
	[SerializeField]
	[ReadOnly]
	private float attackTalentDebug;

	[SerializeField]
	[ReadOnly]
	private float maxHpTalentDebug;

	[SerializeField]
	[ReadOnly]
	private float dmgBonusTalentDebug;

	[ReadOnly]
	[SerializeField]
	private float criticalRateTalentDebug;

	[ReadOnly]
	[SerializeField]
	private float criticalDmgTalentDebug;

	[FormerlySerializedAs("startTroopTalentDebug")]
	[SerializeField]
	[ReadOnly]
	private float hpRecoveryTalentDebug;

	[SerializeField]
	[ReadOnly]
	private float dmgReductionTalentDebug;

	[ReadOnly]
	[SerializeField]
	private float headShotTalentDebug;

	[Space(5f)]
	[ReadOnly]
	[Header("Other")]
	[SerializeField]
	private bool headShot;

	private const float MIN_ATTACK_SPEED = 0.3f;

	private const float MAX_ATTACK_SPEED = 5f;

	[Header("Attack Setting")]
	public string targetLayer;

	public string targetTag;

	public bool chaseTarget;

	[SerializeField]
	private BaseUnitAttackStatSO baseUnitStat;

	[SerializeField]
	private bool isLimitAttackSpeed;

	[Header("Health Setting")]
	[SerializeField]
	private float maxHealth;

	private float currentHeath;

	[SerializeField]
	private bool canHeadShot;

	private float attackBuffByUtility;

	private float attackBuffByLevelBuff;

	private float attackSpeedBuffByUtility;

	private float attackSpeedBuffByLevelBuff;

	private float attackSpeedDeBuff;

	private float criticalBuffByUtility;

	private float criticalBuffByLevelBuff;

	private float criticalDmgBuffByUtility;

	private float criticalDmgBuffByLevelBuff;

	private float maxHpBuffByLevelBuff;

	private float maxHpBuffByUtility;

	[ReadOnly]
	[SerializeField]
	private float cacheAtkTalent;

	[SerializeField]
	[ReadOnly]
	private float cacheMaxHpTalent;

	[SerializeField]
	[ReadOnly]
	private float cacheDmgBonusTalent;

	[SerializeField]
	[ReadOnly]
	private float cacheCriticalRateTalent;

	[ReadOnly]
	[SerializeField]
	private float cacheCriticalDmgTalent;

	[SerializeField]
	[ReadOnly]
	private float cacheDmgReductionTalent;

	[SerializeField]
	[ReadOnly]
	private float cacheHeadShotTalent;

	private float BaseAttack => 0f;

	private float BaseAttackSpeed => 0f;

	private float BaseCriticalRate => 0f;

	private float BaseCriticalDmg => 0f;

	public float CurrentAttack => 0f;

	public float CurrentAttackSpeed => 0f;

	private float CurrentCriticalDmg => 0f;

	public float CurrentCriticalRate => 0f;

	public float ChaseTargetRangeNormal => 0f;

	public float ChaseTargetRangeInPath => 0f;

	public float AttackRange => 0f;

	public float FindTargetRange => 0f;

	public float AttackCritical => 0f;

	private float BaseMaxHp => 0f;

	public float CurrentHealth
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float MaxHealth => 0f;

	public bool Headshot => false;

	private float AttackBuffByUtility
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float AttackBuffByLevelBuff
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float AttackBuff => 0f;

	public float AttackSpeedBuffByUtility
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float AttackSpeedBuffByLevel
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float AttackSpeedBuff => 0f;

	private float AttackSpeedDeBuff
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float CriticalBuffByUtility
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float CriticalBuffByLevelBuff
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float CritBuff => 0f;

	private float CriticalDmgBuffByUtility
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float CritDmgBuffByLevelBuff
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float CriticalDmgBuff => 0f;

	private float MaxHPBuffByLevelBuff
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float MaxHPBuffByUtility
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float MaxHpBuff => 0f;

	public float CacheAtkTalent => 0f;

	public float CacheMaxHpTalent => 0f;

	public float CacheDmgBonusTalent => 0f;

	public float CacheCriticalRateTalent => 0f;

	public float CacheCriticalDmgTalent => 0f;

	public float CacheDmgReductionTalent => 0f;

	public float CacheHeadShotTalent => 0f;

	public void Init()
	{
	}

	private void CacheTalentStat()
	{
	}

	public void InitHp()
	{
	}

	private void UpdateStat()
	{
	}

	private void InitEnemyCanHeadShot()
	{
	}

	public void BuffAttackSpeedByUtility(float value, bool isSetValue)
	{
	}

	public void BuffAtkByUtility(float value, bool isSetValue)
	{
	}

	public void BuffCritical(float value, bool isSetValue)
	{
	}

	public void BuffCriticalDmg(float value, BuffType buffType, bool isSetValue)
	{
	}

	public void DeBuffAttackSpeed(float attackSpeedDeBuffValue, bool isSetValue = false)
	{
	}

	public void ClearAttackSpDeBuff()
	{
	}

	private void ResetAttackBuff()
	{
	}

	public void ResetAttackSpeedBuff()
	{
	}

	public void ResetAttackSpeedDeBuff()
	{
	}

	private void ResetCriticalBuff()
	{
	}

	private void ResetCriticalDmgBuff()
	{
	}

	private void ResetAllBuff()
	{
	}

	public void ApplyBuffLevel(Tuple<bool, float> attack, Tuple<bool, float> attackSpeed, Tuple<bool, float> criticalChange, Tuple<bool, float> criticalDmg, Tuple<bool, float> maxHp)
	{
	}

	public void BuffMaxHpByUtility(float value, bool isSetValue)
	{
	}

	private void ResetHpBuff()
	{
	}
}
