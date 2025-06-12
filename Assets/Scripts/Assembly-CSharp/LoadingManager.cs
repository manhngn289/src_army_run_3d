using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aluta;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadingManager : Singleton<LoadingManager>
{
	[CompilerGenerated]
	private sealed class _003CInitAds_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CInitAds_003Ed__11(int _003C_003E1__state)
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
	private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingManager _003C_003E4__this;

		private AsyncOperation _003CasyncOperation_003E5__2;

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
		public _003CStart_003Ed__9(int _003C_003E1__state)
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

	private const string GAMEPLAY_SCENE = "GameplayScene";

	private const float WAIT_TIME = 5f;

	[SerializeField]
	private float loadingTime;

	[SerializeField]
	private TMP_Text loadingTxt;

	[SerializeField]
	private Image fillLoadingImg;

	[SerializeField]
	private GameObject poolTR;

	private Sequence sequence;

	[Header("TEST")]
	[SerializeField]
	private bool testLoading;

	[SerializeField]
	private string testScene;

	[IteratorStateMachine(typeof(_003CStart_003Ed__9))]
	private IEnumerator Start()
	{
		return null;
	}

	private void MoveObjectLoadingToGamePlay()
	{
	}

	[IteratorStateMachine(typeof(_003CInitAds_003Ed__11))]
	private static IEnumerator InitAds()
	{
		return null;
	}
}
