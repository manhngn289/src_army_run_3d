using System;
using System.Collections.Generic;
using Facebook.Unity;
using UnityEngine;
using UnityEngine.UI;

public class PurchasePage : MonoBehaviour
{
	[SerializeField]
	private Button _loadProductsBtn;

	[SerializeField]
	private Button _loadPurchasesBtn;

	[SerializeField]
	private GameObject _productRowPrefab;

	[SerializeField]
	private Transform _productScrollTransform;

	[SerializeField]
	private GameObject _purchaseRowPrefab;

	[SerializeField]
	private Transform _purchaseScrollTransform;

	private LogScroller _logScroller;

	private IList<Product> _products;

	private void Awake()
	{
	}

	public void CheckReady()
	{
	}

	public void ConsumePurchase(Purchase purchase, Action<bool> callback)
	{
	}

	public void LoadProducts()
	{
	}

	public void LoadPurchases()
	{
	}

	public void MakePurchase(Product product)
	{
	}

	public void ToggleShowConsumedClicked(bool show)
	{
	}

	private void AddPurchase(Purchase purchase, bool setToTop)
	{
	}

	private void LogText(string text)
	{
	}
}
