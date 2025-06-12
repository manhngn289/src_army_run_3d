using System;
using Everest.CustomEditor;
using UnityEngine;

public class UIAnimation_NoAdsPopup : PopupAnimation
{
	[SerializeField]
	private Transform buyBtn;

	[SerializeField]
	private AnimationCurve scaleCurve;

	public override Action OnShow { get; set; }

	public override Action OnHide { get; set; }

	[Button(null)]
	public override void ShowAnim()
	{
	}

	public override void ShowPopupElement(Action onShowElementDone = null)
	{
	}

	public override void HideAnim()
	{
	}

	public override void HidePopupElement(Action onHideElementDone = null)
	{
	}

	public override void ResetElement()
	{
	}
}
