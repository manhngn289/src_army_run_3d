using System;
using Everest.CustomEditor;
using UnityEngine;

public class UIAnimation_LevelBuffPopup : PopupAnimation
{
	[SerializeField]
	private CanvasGroup[] buttonAlphas;

	[SerializeField]
	private float delayPerItem;

	[SerializeField]
	private GameObject blockInteract;

	public override Action OnShow { get; set; }

	public override Action OnHide { get; set; }

	public override void ResetElement()
	{
	}

	[Button(null)]
	public override void ShowAnim()
	{
	}

	public override void HideAnim()
	{
	}

	public override void ShowPopupElement(Action onShowElementDone = null)
	{
	}

	public override void HidePopupElement(Action onHideElementDone = null)
	{
	}
}
