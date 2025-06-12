using UnityEngine;

public abstract class PopupAnimationElement : MonoBehaviour, ICanAnimatePopupElement
{
	public abstract void HideAnim();

	public abstract void ResetElement();

	public abstract void ShowAnim();

	public abstract void SpecialAnim();
}
