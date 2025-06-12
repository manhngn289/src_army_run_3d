using System.Collections.Generic;
using Everest;
using Everest.CustomEditor;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class PopupTalent : PopupSingleton<PopupTalent>
{
	public const int UPGRADE_TALENT_PRICE = 200;

	private const float UPGRADE_SEQUENCE_INCREASE_RATE = 0.15f;

	private const int LIMIT_UPGRADE_SEQUENCE_INCREASE_RATE = 7;

	private const int LIMIT_NORMAL_TALENT_LEVEL_DIF = 4;

	private const int LIMIT_SPECIAL_TALENT_LEVEL_DIF = 2;

	private const int TUTORIAL_ID = 1;

	[DisplayAsString]
	private List<UITalentItem> allTalent;

	public EnumResource<TalentType, Sprite> talentIconSprites;

	[SerializeField]
	private List<UITalentItem> specialTalentUIItems;

	[SerializeField]
	private List<UITalentItem> normalTalentUIItems;

	[SerializeField]
	private int randomSequenceLong;

	[SerializeField]
	private float delayRandomItemBase;

	[FormerlySerializedAs("delayRandomItemIncre")]
	[SerializeField]
	private float delayRandomItemIncrease;

	[SerializeField]
	private TMP_Text talentDescriptionTxt;

	[SerializeField]
	private TMP_Text talentValueTxt;

	[SerializeField]
	private TMP_Text currentElixirTxt;

	[SerializeField]
	private TMP_Text upgradePriceTxt;

	[SerializeField]
	private TMP_Text adsTicketQuantityTxt;

	[SerializeField]
	private GameObject blockInteractGO;

	[FormerlySerializedAs("talentInfo")]
	[SerializeField]
	private CanvasGroup talentInfoAlpha;

	[SerializeField]
	[Header("Tutorial")]
	private List<TutorialStepCheckerUI> tutorialStepCheckerUIs;

	private Coroutine upgradeTalentAnimCoroutine;

	private int talentUpgradeId;

	private bool isUnlockTalent;

	private List<UITalentItem> talentUIUpgradeAnim;

	private Coroutine endUpgradeAnimCoroutine;

	private bool isEndUpgradeSequence;

	[SerializeField]
	private GameObject useElixirUI;

	[SerializeField]
	private GameObject useAdsUI;

	[SerializeField]
	private GameObject useFree;

	[SerializeField]
	private GameObject useAdsTicket;

	private float CurrentSpecialTalentRate => 0f;

	public static bool HasTalentToUpgrade => false;

	private TalentType RandomTalentToUpgrade => default(TalentType);

	protected override void LoadData()
	{
	}

	public void UpgradeRandomTalent()
	{
	}

	private void UpgradeTalentRandomAnim(List<int> sequenceRandom, List<UITalentItem> uiTalentUpgrades, bool isUnlockTalent)
	{
	}

	public void SkipUpgradeTalentAnim()
	{
	}

	private void EndRandomUpgradeTalent(bool unlockTalent, List<UITalentItem> uiTalentUpgrades, int endIndex)
	{
	}

	private void DeActiveAllOutline(bool isImmediate)
	{
	}

	public void SelectTalent(UITalentItem item)
	{
	}

	public void RefreshUI()
	{
	}

	public override void HidePopup()
	{
	}
}
