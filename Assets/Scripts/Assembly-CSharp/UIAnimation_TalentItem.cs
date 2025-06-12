using System;
using Coffee.UIExtensions;
using DG.Tweening;
using Everest.CustomEditor;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIAnimation_TalentItem : PopupAnimationElement
{
	[SerializeField]
	private CanvasGroup itemAlpha;

	[SerializeField]
	private Transform talentIcon;

	[SerializeField]
	private Transform talentLockOverlayGO;

	[SerializeField]
	private CanvasGroup talentLockOverlayAlpha;

	[FormerlySerializedAs("backCard")]
	[SerializeField]
	private GameObject itemBack;

	[SerializeField]
	private Transform itemContent;

	[SerializeField]
	private Image itemLightImg;

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

	[SerializeField]
	private Transform initParent;

	[SerializeField]
	private Transform specialPosParent;

	[SerializeField]
	private UIParticle upgradeFX;

	[SerializeField]
	private UIParticle upgradeFX2;

	public override void HideAnim()
	{
	}

	public override void ResetElement()
	{
	}

	public override void ShowAnim()
	{
	}

	[Button(null)]
	public override void SpecialAnim()
	{
	}

	[Button(null)]
	public void UpgradeTalent(Action onAnimDone)
	{
	}
}
