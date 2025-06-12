using Aluta;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIItemSkipitPack : MonoBehaviour
{
	[ReadOnly]
	[SerializeField]
	private UIShopManager shopManager;

	[SerializeField]
	private SkipItPackShopSetting skipItPackShopSetting;

	[SerializeField]
	private Image packIconImg;

	[SerializeField]
	private TMP_Text rewardQuantityTxt;

	[SerializeField]
	private TMP_Text rewardQuantityShadowTxt;

	[SerializeField]
	private Text packPriceTxt;

	public void SetData(UIShopManager uiShopManager)
	{
	}

	public void BuyPack()
	{
	}
}
