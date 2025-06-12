using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Google.Play.AppUpdate.Samples.AppUpdateDemo.Scripts
{
	public class StartUpdateFlowAction : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStartUpdateCoroutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StartUpdateFlowAction _003C_003E4__this;

			private AppUpdateInfo _003CappUpdateInfo_003E5__2;

			private AppUpdateRequest _003CstartUpdateRequest_003E5__3;

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
			public _003CStartUpdateCoroutine_003Ed__11(int _003C_003E1__state)
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

		public Text statusText;

		public Button startUpdateFlowButton;

		public RectTransform buttonOutline;

		public GetAppUpdateInfoAction getAppUpdateInfoAction;

		public UpdateDownloader updateDownloader;

		public AppUpdateType appUpdateType;

		private AppUpdateManager _appUpdateManager;

		public void Start()
		{
		}

		protected void Update()
		{
		}

		public void ButtonEventStartUpdateFlow()
		{
		}

		private void ChangeButtonDisplay(bool isShown)
		{
		}

		[IteratorStateMachine(typeof(_003CStartUpdateCoroutine_003Ed__11))]
		private IEnumerator StartUpdateCoroutine()
		{
			return null;
		}

		private void SetStatusText(string text)
		{
		}
	}
}
