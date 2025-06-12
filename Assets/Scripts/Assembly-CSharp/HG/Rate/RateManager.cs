using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Google.Play.Common;
using Google.Play.Review;
using UnityEngine;
using UnityEngine.UI;

namespace HG.Rate
{
	public class RateManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CInitReview_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RateManager _003C_003E4__this;

			public bool force;

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
			public _003CInitReview_003Ed__25(int _003C_003E1__state)
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
		private sealed class _003CLaunchReview_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RateManager _003C_003E4__this;

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
			public _003CLaunchReview_003Ed__27(int _003C_003E1__state)
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
		private List<GameObject> starsOn;

		[SerializeField]
		private RectTransform starRow;

		[SerializeField]
		private GameObject feedbackObj;

		[SerializeField]
		private GameObject titleObject;

		[SerializeField]
		private RectTransform container;

		[SerializeField]
		private Transform topPoint;

		[SerializeField]
		private Canvas canvas;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private Button btnBackdrop;

		[SerializeField]
		private GameObject objSubmitGray;

		[SerializeField]
		private GameObject objSubmitGreen;

		private float effectTime;

		private Sequence sequence1;

		private Sequence sequence2;

		private bool showFB;

		private float panelHeight;

		private ReviewManager _reviewManager;

		private PlayReviewInfo _playReviewInfo;

		private Coroutine _coroutine;

		public void ShowPopup()
		{
		}

		public void HidePopup()
		{
		}

		public void OnStarClick(int value)
		{
		}

		private void ShowFeedback()
		{
		}

		private void OnDestroy()
		{
		}

		protected void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CInitReview_003Ed__25))]
		private IEnumerator InitReview(bool force = false)
		{
			return null;
		}

		public void RateAndReview()
		{
		}

		[IteratorStateMachine(typeof(_003CLaunchReview_003Ed__27))]
		public IEnumerator LaunchReview()
		{
			return null;
		}

		private void DirectlyOpen()
		{
		}
	}
}
