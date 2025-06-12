using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Play.Common;
using Google.Play.Review;
using HiGame;
using UnityEngine;

public class InAppReviewObject : Singleton<InAppReviewObject>
{
	[CompilerGenerated]
	private sealed class _003CGetPlayReviewInfoFlow_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InAppReviewObject _003C_003E4__this;

		private PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> _003CrequestFlowOperation_003E5__2;

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
		public _003CGetPlayReviewInfoFlow_003Ed__11(int _003C_003E1__state)
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
	private sealed class _003CStartReviewFlow_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InAppReviewObject _003C_003E4__this;

		private PlayAsyncOperation<VoidResult, ReviewErrorCode> _003ClaunchFlowOperation_003E5__2;

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
		public _003CStartReviewFlow_003Ed__12(int _003C_003E1__state)
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

	private ReviewManager _reviewManager;

	private PlayReviewInfo _playReviewInfo;

	private Coroutine _coroutine;

	private int ratingLevel;

	private bool rateOffCountry;

	public int ReviewLevel => 0;

	public bool RateOffCountry => false;

	private void Start()
	{
	}

	public void GetPlayReviewInfo()
	{
	}

	[IteratorStateMachine(typeof(_003CGetPlayReviewInfoFlow_003Ed__11))]
	public IEnumerator GetPlayReviewInfoFlow()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartReviewFlow_003Ed__12))]
	public IEnumerator StartReviewFlow()
	{
		return null;
	}

	private void DirectlyOpen()
	{
	}

	public void StartReview()
	{
	}

	public void OnGetRemoteConfig()
	{
	}
}
