using System;

public interface ICanAnimatePopup
{
	Action OnShow { get; set; }

	Action OnHide { get; set; }

	void ResetElement();

	void ShowAnim();

	void HideAnim();

	void ShowPopupElement(Action onShowElementDone = null);

	void HidePopupElement(Action onHideElementDone = null);
}
