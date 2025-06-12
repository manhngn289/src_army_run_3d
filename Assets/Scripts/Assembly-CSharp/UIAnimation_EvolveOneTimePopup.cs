using System;

public class UIAnimation_EvolveOneTimePopup : PopupAnimation
{
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

	public override void ShowAnim()
	{
	}

	public override void ShowPopupElement(Action onShowElementDone = null)
	{
	}
}
