using System;
using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class UnitHealth : MonoBehaviour, ICanTakeDmg
{
	[SerializeField]
	protected bool selfInit;

	[SerializeField]
	[ReadOnly]
	private bool unitInitialized;

	[ReadOnly]
	[SerializeField]
	private bool actionInitialized;

	public Action<AttackerType> DeadAction;

	public Action<DamageInfo, UnitHealth> TakeDmgAction;

	public UnitStatInfo unitStatInfo;

	[SerializeField]
	private Transform pointAttacked;

	public Transform healthBarPoint;

	public HealthBar healthBar;

	private IUnitController controller;

	public bool immortal;

	[SerializeField]
	[Header("Utility")]
	private bool useShield;

	[ReadOnly]
	[SerializeField]
	private float shieldScale;

	[SerializeField]
	private ShieldData shieldData;

	[SerializeField]
	private float dodgeChange;

	[SerializeField]
	private float immortalDuration;

	private Coroutine healOverTimeCor;

	private const float HEAL_OVER_TIME_DELAY = 1f;

	[Header("TEST")]
	[SerializeField]
	private bool autoInit;

	[SerializeField]
	private bool isTest;

	[SerializeField]
	private DamageInfo testDmg;

	public float MaxHealth => 0f;

	public MonoBehaviour SelfBehaviour => null;

	[DisplayAsString]
	public bool IsDead => false;

	public Transform PointAttacked => null;

	private void Start()
	{
	}

	public void InitHeath(IUnitController unitController = null)
	{
	}

	private void InitAction()
	{
	}

	private void InitShield()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDespawned()
	{
	}

	[Button(null)]
	public void Dead()
	{
	}

	private void ImmortalTime(float duration)
	{
	}

	public void Dead(AttackerType attackerType, KillAllyType killerType)
	{
	}

	public bool Dodge(DamageInfo damageInfo)
	{
		return false;
	}

	public bool Dodge(AttackerType attackerType)
	{
		return false;
	}

	public void TakeDmg(DamageInfo damageInfo, KillAllyType killAllyType)
	{
	}

	public void HealFullHp()
	{
	}

	private void HealOverTime()
	{
	}

	[Button(null)]
	private void TestTakeDmg()
	{
	}
}
