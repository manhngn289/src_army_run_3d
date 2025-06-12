using Facebook.Unity;
using UnityEngine;
using UnityEngine.UI;

public class ProductRowPrefab : MonoBehaviour
{
	[SerializeField]
	private RawImage _thumbImg;

	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _productIdText;

	[SerializeField]
	private GameObject _buyBtn;

	private Product _product;

	private LogScroller _logScroller;

	private PurchasePage _parentScript;

	private void Awake()
	{
	}

	public void OnLogBtnClick()
	{
	}

	public void OnPurchaseBtnClick()
	{
	}

	public void Initialize(PurchasePage parentScript, LogScroller logScroller, Product product)
	{
	}

	private void SetThumb(string productId, string url)
	{
	}

	private void LogText(string text)
	{
	}
}
