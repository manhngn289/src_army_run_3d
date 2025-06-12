using GoogleMobileAds.Api;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NativeAdHandler : MonoBehaviour
{
	public string NativeAdUnitId;

	private NativeAd nativeAd;

	private bool nativeAdLoaded;

	public RawImage AdIconTexture;

	public TextMeshProUGUI AdHeadline;

	public TextMeshProUGUI AdDescription;

	public GameObject AdLoaded;

	public GameObject AdLoading;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void RequestNativeAd()
	{
	}

	private void HandleNativeAdLoaded(object sender, NativeAdEventArgs args)
	{
	}

	private void HandleNativeAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
	}
}
