using Aluta;
using Coffee.UIExtensions;
using DG.Tweening;
using Everest.CustomEditor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupUnlockSkinProgress : PopupSingleton<PopupUnlockSkinProgress>
{
	[ReadOnly]
	[SerializeField]
	private int previousProgress;

	[ReadOnly]
	[SerializeField]
	private int skinInProgress;

	[SerializeField]
	[ReadOnly]
	private bool unlockSkin;

	[SerializeField]
	private SkinUnlockRequired skinUnlockRequiredData;

	[SerializeField]
	private Sprite[] skinPreviewSprites;

	[SerializeField]
	private Image previewImageFill;

	[SerializeField]
	private Image previewImageBg;

	[SerializeField]
	private TMP_Text skinNameTxt;

	[SerializeField]
	private TMP_Text skinNameUnderlayTxt;

	[SerializeField]
	private TMP_Text progressTxt;

	[SerializeField]
	private CanvasGroup titleAlpha;

	[SerializeField]
	private CanvasGroup unlockBtn;

	[SerializeField]
	private CanvasGroup skipBtn;

	[SerializeField]
	private RectTransform skipBtnRec;

	[SerializeField]
	private UIParticle fullProgressFx;

	[SerializeField]
	private GameObject previewUnlock;

	[SerializeField]
	private float skinCurrentUnlock;

	private Tweener increaseValueTweener;

	private int RequiredUnlockSkin(int id)
	{
		return 0;
	}

	protected override void LoadData()
	{
	}

	private void OnEnable()
	{
	}

	[Button(null)]
	private void IncreaseProgress()
	{
	}

	private void OnDisable()
	{
	}

	public void UnlockSkinBtn()
	{
	}

	public void SkipBtn()
	{
	}

	private void UnlockSkin()
	{
	}

	private void OnProgressFull()
	{
	}
}
