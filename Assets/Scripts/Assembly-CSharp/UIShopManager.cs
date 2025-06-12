using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIShopManager : PopupSingleton<UIShopManager>
{
	[SerializeField]
	private TMP_Text goldTxt;

	[SerializeField]
	private TMP_Text elixirTxt;

	[SerializeField]
	private TMP_Text skipItTxt;

	[SerializeField]
	private GlobalResourceShower coinShower;

	[SerializeField]
	private GlobalResourceShower elixirShower;

	[SerializeField]
	private GlobalResourceShower adsTicketShower;

	[SerializeField]
	private ResourceEmitTarget coinEmitTarget;

	[SerializeField]
	private ResourceEmitTarget elixirEmitTarget;

	[SerializeField]
	private ResourceEmitTarget adsTicketEmitTarget;

	[SerializeField]
	private GameObject noAdsPackGo;

	[SerializeField]
	private GameObject starterPackGo;

	[SerializeField]
	private GameObject currencyDailyGo;

	[SerializeField]
	private GameObject skipItPackGo;

	[SerializeField]
	private Text starterPackPriceTxt;

	[SerializeField]
	private Text noAdsPackPriceTxt;

	[SerializeField]
	private UIItemDailyCurrency[] dailyCurrencies;

	[SerializeField]
	private UIItemSkipitPack[] skipItPacks;

	public int emitResourceSourceId;

	[SerializeField]
	private ScrollRect shopScroll;

	[SerializeField]
	private float dailyCurrencyPos;

	[SerializeField]
	private float skipItPos;

	public Transform EmitResourceSource => null;

	protected override void LoadData()
	{
	}

	public void BuyStarterPack()
	{
	}

	public void BuyNoAdsPack()
	{
	}

	public void RefreshResourceUI(params bool[] emitResources)
	{
	}

	private void RefreshUI(params bool[] emitResources)
	{
	}

	public void ScrollToPack(int packID = -1)
	{
	}

	public override void HidePopup()
	{
	}
}
