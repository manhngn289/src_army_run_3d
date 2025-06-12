using Aluta;
using TMPro;
using UnityEngine;

public class UIItemDailyCurrency : MonoBehaviour
{
	private const int RESOURCE_MULTIPLY = 2;

	[SerializeField]
	[ReadOnly]
	private UIShopManager uiShopManager;

	[SerializeField]
	[ReadOnly]
	private int itemId;

	[SerializeField]
	private TMP_Text remainingTimesTxt;

	[SerializeField]
	private TMP_Text freeTxt;

	[SerializeField]
	private TMP_Text rewardAmountTxt;

	private int ResourceTake => 0;

	private bool CanTakeReward => false;

	public void SetData(int id, UIShopManager shopManager)
	{
	}

	private void RefreshUI()
	{
	}

	public void BtnBuyClick()
	{
	}

	private void BuyPack()
	{
	}
}
