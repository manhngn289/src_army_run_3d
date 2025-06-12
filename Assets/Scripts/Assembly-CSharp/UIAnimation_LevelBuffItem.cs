using System;
using DG.Tweening;
using Everest.CustomEditor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimation_LevelBuffItem : PopupAnimationElement
{
	[SerializeField]
	private CanvasGroup itemAlpha;

	[SerializeField]
	private Transform itemBGTR;

	[SerializeField]
	private Transform itemIconPreviewTR;

	[SerializeField]
	private TMP_Text itemTitleTxt;

	[SerializeField]
	private TMP_Text ItemDescriptionTxt;

	[SerializeField]
	private Image epicGlow;

	[SerializeField]
	private Vector3 initBGPos;

	[SerializeField]
	private Image useTicketImg;

	[SerializeField]
	private Image useAdsImg;

	[SerializeField]
	private Image selectedGoImg;

	[SerializeField]
	private GameObject previewGo;

	[SerializeField]
	private Image itemBack;

	[SerializeField]
	private Transform itemContent;

	[SerializeField]
	private Transform initParent;

	[SerializeField]
	private Transform specialPosParent;

	[SerializeField]
	private int flipTimes;

	[SerializeField]
	private float flipDuration;

	[SerializeField]
	private float scaleUp;

	[SerializeField]
	private float timeScaleUp;

	[SerializeField]
	private Ease easeScaleUp;

	[SerializeField]
	private float timeScaleDown;

	[SerializeField]
	private Ease easeScaleDown;

	[Header("Clone")]
	[SerializeField]
	private float titleCloneScale;

	[SerializeField]
	private float timeScaleTitleClone;

	[SerializeField]
	private Ease easeScaleTitleClone;

	[SerializeField]
	private float timeFadeTitleClone;

	[SerializeField]
	private Ease easeFadeTitleClone;

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

	private void HideAnim(Action onHide)
	{
	}

	[Button(null)]
	public override void SpecialAnim()
	{
	}

	[Button(null)]
	private void FadeCloneBackImg()
	{
	}

	public void SelectItemAnim(Action onAnimDone)
	{
	}
}
