using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerHomeAnimationController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRandomIdle_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerHomeAnimationController _003C_003E4__this;

		private float _003CcurrentTimeToNewIdle_003E5__2;

		private int _003CpreviousIdle_003E5__3;

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
		public _003CRandomIdle_003Ed__17(int _003C_003E1__state)
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

	private const string VICTORY = "Victory";

	private const string LOSE_1 = "Lose_1";

	private const string LOSE_2 = "Lose_2";

	private const string BONUS_TROOP = "Run_BonusTroop";

	private const string UPGRADE = "Upgrade";

	private readonly string[] idlesNoGun;

	[SerializeField]
	private Animator[] troopHomeAnimators;

	[SerializeField]
	private GameObject[] troopHomeWeapons;

	private Coroutine randomIdleCoroutine;

	[SerializeField]
	private float[] idleDurations;

	private Coroutine waitUpgradeDoneCoroutine;

	private Animator TroopActive => null;

	public void FullProgressPreviewSkin(int id)
	{
	}

	public void Victory()
	{
	}

	public void Lose()
	{
	}

	public void BonusTroop()
	{
	}

	public void Idle()
	{
	}

	[IteratorStateMachine(typeof(_003CRandomIdle_003Ed__17))]
	private IEnumerator RandomIdle()
	{
		return null;
	}

	public void Upgrade()
	{
	}
}
