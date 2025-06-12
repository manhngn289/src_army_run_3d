using System;
using Everest.CustomEditor;
using UnityEngine;

public class UIAnimation_TalentPopup : PopupAnimation
{
	[SerializeField]
	private CanvasGroup[] topUIAlpha;

	[SerializeField]
	private CanvasGroup[] botUIAlpha;

	[SerializeField]
	private float delayPerItem;

	public override Action OnShow { get; set; }

	public override Action OnHide { get; set; }

	public override void HideAnim()
	{
	}

	public override void HidePopupElement(Action onHideElementDone = null)
	{
	}

	public override void ResetElement()
	{
	}

	[Button(null)]
	public override void ShowAnim()
	{
	}

	public override void ShowPopupElement(Action onShowElementDone = null)
	{
	}
}
