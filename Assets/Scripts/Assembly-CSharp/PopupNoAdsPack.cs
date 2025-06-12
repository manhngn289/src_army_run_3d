using UnityEngine;
using UnityEngine.UI;

public class PopupNoAdsPack : PopupSingleton<PopupNoAdsPack>
{
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
