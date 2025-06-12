using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupSkin : PopupSingleton<PopupSkin>
{
	public const int AllSkinInGame = 2;

	private static readonly int SwitchBlack;

	[SerializeField]
	private Transform[] troopPreviewTRs;

	[SerializeField]
	private Vector3[] previewPos;

	[SerializeField]
	private float[] previewScale;

	[SerializeField]
	private GameObject[] leftRightPreviewBtn;

	[SerializeField]
	private TMP_Text currentTierTxt;

	[SerializeField]
	private TMP_Text currentTierBonusStatTxt;

	[SerializeField]
	private GameObject unlockedValueGo;

	[SerializeField]
	private GameObject notUnlockValueGo;

	[SerializeField]
	private int currentSkinPreview;

	[SerializeField]
	private Renderer[] troopRendererBody;

	[SerializeField]
	private Renderer[] troopWeaponRenderer;

	[SerializeField]
	private Button equipBtn;

	[SerializeField]
	private Button unlockBtn;

	[SerializeField]
	private TMP_Text equipBtnTxt;

	public static readonly float[] SkinBuffStat;

	private bool isChangeSkin;

	protected override void LoadData()
	{
	}

	public void ChangePreview(bool isLeft)
	{
	}

	private void RefreshUI()
	{
	}

	public void UnlockBtn()
	{
	}

	private void UnlockSkin()
	{
	}

	private void LockTroopNotUnlock()
	{
	}

	private void ChangePreviewTroop(int troopCurrentPreview, bool immediately)
	{
	}

	public void EquipSkin()
	{
	}

	public static float GetSkinBuffValue()
	{
		return 0f;
	}

	public override void HidePopup()
	{
	}
}
