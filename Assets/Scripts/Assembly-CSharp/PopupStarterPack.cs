using UnityEngine;
using UnityEngine.UI;

public class PopupStarterPack : PopupSingleton<PopupStarterPack>
{
	public const int CoinReward = 6000;

	public const int ElixirReward = 1500;

	[SerializeField]
	private Text packPriceText;

	[SerializeField]
	private GameObject tapToCloseBtnGo;

	protected override void LoadData()
	{
	}

	public void BuyPack()
	{
	}
}
