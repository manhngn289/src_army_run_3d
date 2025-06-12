using System;
using Aluta;
using UnityEngine;

public abstract class UnitController : MonoBehaviour, IUnitController
{
	[ReadOnly]
	public bool unitInitialized;

	public UnitStatInfo statInfo;

	public UnitAttack attacker;

	public UnitHealth health;

	public UnitMovement mover;

	[SerializeField]
	protected UnitAnimationController animationController;

	[SerializeField]
	protected UnitState currentMoveState;

	[SerializeField]
	protected UnitState previousMoveState;

	[SerializeField]
	protected bool useGravity;

	[SerializeField]
	protected GameObject[] objectDisableOnDead;

	public bool isDeadByTrap;

	protected bool Freezing;

	[SerializeField]
	private bool test;

	public bool IsDead => false;

	public UnitAnimationController AnimationController => null;

	public virtual UnitState CurrentMoveState
	{
		get
		{
			return default(UnitState);
		}
		set
		{
		}
	}

	public UnitState PreviousMoveState
	{
		get
		{
			return default(UnitState);
		}
		set
		{
		}
	}

	public virtual bool CanAttack { get; }

	public abstract bool Jumping { get; set; }

	public Action<UnitController> DeadAction { get; set; }

	public virtual Transform LimitTR { get; }

	public virtual Vector3 LimitSize { get; }

	public UnitStatInfo StatInfo => null;

	public UnitHealth Health => null;

	public void CachePreviousState()
	{
	}

	public void BackToPreviousState()
	{
	}

	public virtual void Init(bool useSoundAndAnim = true)
	{
	}

	protected void ResetSomeElement()
	{
	}

	private void OnEnable()
	{
	}

	public virtual void OnSpawned()
	{
	}

	protected virtual void OnDespawned()
	{
	}

	public virtual void Dead()
	{
	}
}
