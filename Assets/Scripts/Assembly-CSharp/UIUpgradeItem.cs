using Aluta;
using Everest;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIUpgradeItem : MonoBehaviour
{
	public TroopUpgradeType itemType;

	[SerializeField]
	[ReadOnly]
	private TroopUpgradeManager troopUpgradeManager;

	[Header("UI Elements")]
	[SerializeField]
	private TMP_Text upgradeNameTxt;

	[SerializeField]
	private TMP_Text upgradeLevelTxt;

	[SerializeField]
	private Image upgradeIconImg;

	[SerializeField]
	private TMP_Text upgradePriceTxt;

	[SerializeField]
	private GameObject upgradeNotificationGo;

	[SerializeField]
	private GameObject useGoldGo;

	[SerializeField]
	private GameObject useAdsGo;

	[SerializeField]
	private GameObject useAdsTicketGo;

	[SerializeField]
	private GameObject useFreeGo;

	[SerializeField]
	private Button upgradeButton;

	[SerializeField]
	private EnumResource<TroopUpgradeType, Sprite> upgradeIconSprites;

	[SerializeField]
	private ParticleSystem[] upgradeEffect;

	private bool CanUpgradeByGold => false;

	private bool CanUpgrade => false;

	public void SetData(TroopUpgradeType upgradeType, TroopUpgradeManager troopUpgradeManager)
	{
	}

	public void RefreshUI()
	{
	}

	private void CheckShowNotification()
	{
	}

	private void DelayEnableUpgrade()
	{
	}

	public void OnUpgradeClick()
	{
	}

	private void UpgradeTroopByType()
	{
	}

	private static int GetPrice(TroopUpgradeType upgradeType)
	{
		return 0;
	}
}
