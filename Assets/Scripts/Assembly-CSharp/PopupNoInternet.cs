using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupNoInternet : PopupSingleton<PopupNoInternet>
{
	[CompilerGenerated]
	private sealed class _003CCheckInternetTask_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupNoInternet _003C_003E4__this;

		private int _003Ctime_003E5__2;

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
		public _003CCheckInternetTask_003Ed__11(int _003C_003E1__state)
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
	private sealed class _003CCheckUpdateInternetConnection_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupNoInternet _003C_003E4__this;

		private WaitForSecondsRealtime _003CwaitTask_003E5__2;

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
		public _003CCheckUpdateInternetConnection_003Ed__1(int _003C_003E1__state)
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
	private sealed class _003CLoadingProgress_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupNoInternet _003C_003E4__this;

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
		public _003CLoadingProgress_003Ed__16(int _003C_003E1__state)
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

	[Header("NoInternet")]
	[SerializeField]
	private Button reconnectButton;

	[SerializeField]
	private TMP_Text loadingTxt;

	[SerializeField]
	private bool gamePauseState;

	private bool connectInternetSuccess;

	private Sequence sequence;

	private PopupSingleton<PopupNoInternet> popupSingletonImplementation;

	protected override void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckUpdateInternetConnection_003Ed__1))]
	private IEnumerator CheckUpdateInternetConnection()
	{
		return null;
	}

	public override void ShowPopup(Transform bgParent = null)
	{
	}

	private void PauseGameIfAvailable()
	{
	}

	private void UnpauseGameIfAvailable()
	{
	}

	protected override void LoadData()
	{
	}

	public void BtnReconnect()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckInternetTask_003Ed__11))]
	private IEnumerator CheckInternetTask()
	{
		return null;
	}

	public override void HidePopup()
	{
	}

	private void OnReconnect(bool isConnected)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadingProgress_003Ed__16))]
	private IEnumerator LoadingProgress()
	{
		return null;
	}
}
