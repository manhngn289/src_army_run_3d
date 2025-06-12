using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShootBulletCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BulletShooter _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private ParticleSystem _003Cbullet_003E5__3;

		private float _003Ctimer_003E5__4;

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
		public _003CShootBulletCoroutine_003Ed__9(int _003C_003E1__state)
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

	public ParticleSystem Muzzle;

	public ParticleSystem Bullet;

	public float BulletSpeed;

	public float Distance;

	public ParticleSystem HitEffect;

	public Transform BulletStartPoint;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void ShootBullet()
	{
	}

	[IteratorStateMachine(typeof(_003CShootBulletCoroutine_003Ed__9))]
	public IEnumerator ShootBulletCoroutine()
	{
		return null;
	}
}
