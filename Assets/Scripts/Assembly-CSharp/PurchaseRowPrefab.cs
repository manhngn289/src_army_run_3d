using Facebook.Unity;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseRowPrefab : MonoBehaviour
{
	[SerializeField]
	private Text _purchaseTokenText;

	[SerializeField]
	private Text _productIdText;

	[SerializeField]
	private Text _purchaseTimeText;

	[SerializeField]
	private GameObject _consumeBtn;

	private string DATE_FORMAT;

	private Purchase _purchase;

	private LogScroller _logScroller;

	private PurchasePage _parentScript;

	public string GetPurchaseToken()
	{
		return null;
	}

	public void OnLogBtnClick()
	{
	}

	public void OnConsumeBtnClick()
	{
	}

	public void Initialize(PurchasePage parentScript, LogScroller logScroller, Purchase purchase)
	{
	}

	private void SetConsumeBtnData(bool isConsumed)
	{
	}
}
