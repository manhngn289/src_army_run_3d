using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Play.Common;
using UnityEngine;
using UnityEngine.UI;

namespace Google.Play.AppUpdate.Samples.AppUpdateDemo.Scripts
{
	public class CompleteUpdateAction : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCompleteUpdateCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CompleteUpdateAction _003C_003E4__this;

			private PlayAsyncOperation<VoidResult, AppUpdateErrorCode> _003Cresult_003E5__2;

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
			public _003CCompleteUpdateCoroutine_003Ed__6(int _003C_003E1__state)
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

		public Button completeUpdateButton;

		private AppUpdateManager _appUpdateManager;

		public void Start()
		{
		}

		private void Update()
		{
		}

		private void ButtonEventCompleteUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CCompleteUpdateCoroutine_003Ed__6))]
		private IEnumerator CompleteUpdateCoroutine()
		{
			return null;
		}

		private void SetStatus(string text)
		{
		}
	}
}
