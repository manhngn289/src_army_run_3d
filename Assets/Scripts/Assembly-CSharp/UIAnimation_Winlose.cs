using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Everest.CustomEditor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimation_Winlose : PopupAnimation
{
	[CompilerGenerated]
	private sealed class _003CShowWinLose_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIAnimation_Winlose _003C_003E4__this;

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
		public _003CShowWinLose_003Ed__36(int _003C_003E1__state)
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
	private PopupWinLose popupWinLose;

	[SerializeField]
	private RectTransform titleRect;

	[SerializeField]
	private Image title;

	[SerializeField]
	private Image backgroundImg;

	[SerializeField]
	private CanvasGroup rewardAlpha;

	[SerializeField]
	private CanvasGroup rewardBtnAlpha;

	[SerializeField]
	private CanvasGroup rewardMultiplierAlpha;

	[SerializeField]
	private RawImage preview;

	[SerializeField]
	private TMP_Text coinsText;

	[SerializeField]
	private TMP_Text elixirText;

	[SerializeField]
	private CanvasGroup nothankBtnAlpha;

	[SerializeField]
	private RectTransform nothankBtnRect;

	[SerializeField]
	private float timeTitleScale;

	[SerializeField]
	private Ease titleEaseScale;

	[SerializeField]
	private float timeTitleFade;

	[SerializeField]
	private Ease titleEaseFade;

	[SerializeField]
	private float timeTitleFadeDelay;

	[SerializeField]
	[Header("Clone")]
	private float titleCloneScale;

	[SerializeField]
	private float timeScaleTitleClone;

	[SerializeField]
	private Ease easeScaleTitleClone;

	[SerializeField]
	private float timeFadeTitleClone;

	[SerializeField]
	private Ease easeFadeTitleClone;

	[SerializeField]
	private float valueTime;

	public override Action OnShow { get; set; }

	public override Action OnHide { get; set; }

	public override void HideAnim()
	{
	}

	public override void HidePopupElement(Action onHideElementDone = null)
	{
	}

	[Button(null)]
	public override void ResetElement()
	{
	}

	[Button(null)]
	public override void ShowAnim()
	{
	}

	[Button(null)]
	private void FadeCloneTitle()
	{
	}

	[IteratorStateMachine(typeof(_003CShowWinLose_003Ed__36))]
	private IEnumerator ShowWinLose()
	{
		return null;
	}

	public override void ShowPopupElement(Action onShowElementDone = null)
	{
	}
}
