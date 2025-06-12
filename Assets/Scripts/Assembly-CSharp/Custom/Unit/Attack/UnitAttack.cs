using Aluta;
using Everest.CustomEditor;
using UnityEngine;

[RequireComponent(typeof(UnitHealth))]
public abstract class UnitAttack : MonoBehaviour
{
	private const int MAX_TARGET_CHECK = 5;

	private const float OFF_SET_ATTACK_RANGE = 0.3f;

	[SerializeField]
	[ReadOnly]
	protected bool unitInitialized;

	[Header("ELEMENTS")]
	[SerializeField]
	protected bool selfInit;

	public UnitAttack target;

	public bool notAttack;

	public IUnitController UnitController;

	public AttackType attackType;

	public UnitMovement unitMovement;

	public UnitLookAt unitLookAt;

	public UnitHealth health;

	public bool newAttackMec;

	public bool useRandomDelayFirstAttack;

	public bool notMoveOnAttack;

	public bool useDelayAttackByAttackSpeed;

	[SerializeField]
	private DamageInfo unitDmgInfo;

	[Header("SKILL")]
	public UnitAttackSkill currentActiveSkill;

	[DisplayAsString]
	private Collider[] targets;

	[SerializeField]
	[ReadOnly]
	private bool enableUseSkill;

	[Header("DEBUG")]
	[ReadOnly]
	[SerializeField]
	private bool attacking;

	[ReadOnly]
	[SerializeField]
	private float currentAttackDelay;

	[ReadOnly]
	[SerializeField]
	private bool wasDelayFirstAttack;

	[ReadOnly]
	[SerializeField]
	private float delayFirstAttackRandom;

	[ReadOnly]
	[SerializeField]
	private float currentDelayPerAttack;

	[ReadOnly]
	public bool usingSkill;

	[Header("ANALYTICS")]
	public AttackerType attackerType;

	[SerializeField]
	private bool isAttackThisTime;

	[SerializeField]
	private float currentTimeToAttack;

	[SerializeField]
	private float currentTimeToResetAttack;

	[SerializeField]
	private float timeToAttackNormalize;

	public UnitStatInfo StatInfo => null;

	[DisplayAsString]
	public float AttackDelay => 0f;

	public float FindTargetRange => 0f;

	[DisplayAsString]
	public bool CanAttack => false;

	private bool IsInAttackRange => false;

	private bool IsTargetInChaseRange => false;

	private void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	public virtual void InitData()
	{
	}

	protected virtual void OnDespawned()
	{
	}

	public bool AcceptUseSkill(UnitAttackSkill skillToUse)
	{
		return false;
	}

	public void OnSkillDone(string skillAnimCondition)
	{
	}

	public void OnSkillDone()
	{
	}

	private void DelayUseSkill()
	{
	}

	public void SetTarget(UnitAttack targetAttacked)
	{
	}

	private void FindTargetToAttack(float checkRadius)
	{
	}

	private void AutoAttackForward()
	{
	}

	private void ChaseTargetToAttack()
	{
	}

	private void AttackTargetInRange()
	{
	}

	private void AttackTarget()
	{
	}

	public virtual void ResetAttack()
	{
	}

	private void ResetAttackNew()
	{
	}

	public abstract void Attack();

	protected virtual void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private bool CriticalHit()
	{
		return false;
	}

	public DamageInfo GetDmg()
	{
		return null;
	}

	protected virtual void OnDrawGizmosSelected()
	{
	}

	private void OnValidate()
	{
	}
}
