using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aluta;
using UnityEngine;

public class UnitAttackRange : UnitAttack
{
	[CompilerGenerated]
	private sealed class _003CDoubleShot_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnitAttackRange _003C_003E4__this;

		public Vector3 bulletPos;

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
		public _003CDoubleShot_003Ed__38(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CDoubleTwinShot_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnitAttackRange _003C_003E4__this;

		public Quaternion bulletRotation;

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
		public _003CDoubleTwinShot_003Ed__40(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CShotgunDoubleShot_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnitAttackRange _003C_003E4__this;

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
		public _003CShotgunDoubleShot_003Ed__48(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CShotgunTwinDoubleShot_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnitAttackRange _003C_003E4__this;

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
		public _003CShotgunTwinDoubleShot_003Ed__49(int _003C_003E1__state)
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

	public Transform attackPoint;

	[SerializeField]
	private BaseBullet bulletPrefab;

	[SerializeField]
	private UnitAttackRangeAttackFxSO fireBulletFXData;

	[SerializeField]
	[ReadOnly]
	private BaseBullet currentBullet;

	[SerializeField]
	private bool randomAngle;

	[SerializeField]
	private float[] randomDir;

	[SerializeField]
	private int randomDirIndex;

	[SerializeField]
	private bool isDecreaseDirection;

	[SerializeField]
	private bool lookAtTargetOnAttack;

	private static readonly int[] ShotgunBulletPerLevel;

	public static int ShotgunLevel;

	public bool shotgunOn;

	public bool twinShotOn;

	public bool doubleShotOn;

	private const float DOUBLE_SHOT_DELAY_PER_BULLET = 0.07f;

	private static readonly List<float> ShotgunBulletAngle;

	[StaticSerialize("ShotgunBulletAngle")]
	public List<float> shotgunBulletAngle;

	public Transform weapon;

	private float timeBetweenAttack;

	private BaseBullet BulletUse
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private Quaternion DefaultRotationBullet => default(Quaternion);

	private bool NormalShot => false;

	private bool ShotgunTwin => false;

	private bool ShotgunDouble => false;

	private bool TwinDouble => false;

	private bool ShotgunTwinDouble => false;

	protected override void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSpawned()
	{
	}

	public void ResetToDefaultBullet()
	{
	}

	protected override void OnDespawned()
	{
	}

	public void ChangeBullet(BaseBullet bulletChange)
	{
	}

	private void GetBullet(Vector3 bulletPos, Quaternion bulletRotation)
	{
	}

	public void FireBullet()
	{
	}

	[IteratorStateMachine(typeof(_003CDoubleShot_003Ed__38))]
	private IEnumerator DoubleShot(Vector3 bulletPos)
	{
		return null;
	}

	private void TwinShot(Quaternion bulletRotation)
	{
	}

	[IteratorStateMachine(typeof(_003CDoubleTwinShot_003Ed__40))]
	private IEnumerator DoubleTwinShot(Quaternion bulletRotation)
	{
		return null;
	}

	public static void ResetShotgunBulletAngles()
	{
	}

	public static void UpdateShotgunBulletAngles()
	{
	}

	private void ShotgunShot(Vector3 bulletPos)
	{
	}

	private void DirectionShot(Vector3 bulletPos, float angleFromForward)
	{
	}

	private void ShotgunTwinShot()
	{
	}

	[IteratorStateMachine(typeof(_003CShotgunDoubleShot_003Ed__48))]
	private IEnumerator ShotgunDoubleShot()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShotgunTwinDoubleShot_003Ed__49))]
	private IEnumerator ShotgunTwinDoubleShot()
	{
		return null;
	}

	private void LookAtToTarget()
	{
	}

	public override void Attack()
	{
	}
}
