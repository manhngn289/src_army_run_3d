using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public abstract class PopupAnimation : MonoBehaviour, ICanAnimatePopup
{
	public Transform popupContent;

	public CanvasGroup popAlpha;

	public List<PopupAnimationElement> elements;

	public List<CanvasGroup> elementAlphas;

	public float delayPerItemDefault;

	public abstract Action OnShow { get; set; }

	public abstract Action OnHide { get; set; }

	public abstract void HideAnim();

	public abstract void HidePopupElement(Action onHideElementDone = null);

	public abstract void ResetElement();

	public abstract void ShowAnim();

	public abstract void ShowPopupElement(Action onShowElementDone = null);

	protected virtual void FadeSequenceElementAlpha(float toValue, float duration, float fromValue = -1f, List<float> delayElementCustom = null, Ease ease = Ease.Linear)
	{
	}

	public virtual void FadeSequenceElementAlpha(float toValue, List<float> durationCustom, float fromValue = -1f, List<float> delayElementCustom = null, Ease ease = Ease.Linear)
	{
	}
}
