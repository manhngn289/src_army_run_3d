using System;
using UnityEngine;

public class UIAnimation_BonusTroopPopup : PopupAnimation
{
	[SerializeField]
	private Transform takeBtn;

	public override Action OnShow { get; set; }

	public override Action OnHide { get; set; }

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
