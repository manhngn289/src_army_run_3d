using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class UnitMovement : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMovePath_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnitMovement _003C_003E4__this;

		private Vector3[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private Vector3 _003CtargetPosition_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CMovePath_003Ed__45(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	protected bool selfInit;

	public float moveSpeed;

	public UnitMoveType moveType;

	[SerializeField]
	private UnitMoveType moveTypeAfterPath;

	[SerializeField]
	private bool canMove;

	public UnitLookAt unitLookAt;

	private IUnitController unitController;

	[Header("MOVE FORWARD")]
	[SerializeField]
	private bool negativeZ;

	[Header("MOVE TO TARGET")]
	[SerializeField]
	private UnitAttack target;

	[Header("MOVE CUSTOM")]
	[SerializeField]
	private Vector3[] moveCustomData;

	[Header("SPECIAL MOVE")]
	[SerializeField]
	private bool isUseSpecialMove;

	[SerializeField]
	private bool lookAtSpecialMove;

	[SerializeField]
	private bool isLimitAroundTarget;

	[SerializeField]
	private float limitRadius;

	[SerializeField]
	private float limitMinRadius;

	[SerializeField]
	private float minDistanceMove;

	[SerializeField]
	private float maxDistanceMove;

	[SerializeField]
	private float restrictedAngle;

	private Coroutine specialMoveCor;

	[SerializeField]
	[ReadOnly]
	private Vector3 randomPos;

	[SerializeField]
	private int tryTime;

	private Coroutine moveFollowPath;

	private Coroutine waitInitPathDone;

	public bool followPathFirst;

	[SerializeField]
	private bool notBreakPath;

	[DisplayAsString]
	public bool AllowAttack => false;

	[DisplayAsString]
	public bool IsFollowingPath => false;

	[DisplayAsString]
	private bool isWaitingFollowPathDone => false;

	public bool CanMove
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3 ForwardMovement => default(Vector3);

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDespawned()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Move()
	{
	}

	private bool IsValidPoint(Vector3 point, Vector3 oldPos)
	{
		return false;
	}

	public void StopSpecialMove()
	{
	}

	private Vector3? RanPosMoveSpecial()
	{
		return null;
	}

	private void SpecialMove()
	{
	}

	public void SetMovePathDoneAction(EnemyMoveType moveTypeAfterPath)
	{
	}

	[IteratorStateMachine(typeof(_003CMovePath_003Ed__45))]
	private IEnumerator MovePath()
	{
		return null;
	}

	private void MoveFollowPath()
	{
	}

	public void SetPathMove(Vector3 difInitPos, Vector3[] path)
	{
	}

	public void SetTarget(UnitAttack target)
	{
	}

	public void SetTargetLookAt(UnitStatInfo target)
	{
	}

	public void SetTargetLookAt(Vector3 target)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
