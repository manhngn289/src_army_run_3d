using GoogleMobileAds.Api;
using HiGame;
using UnityEngine.Events;

internal class GoogleAdsMgr : Singleton<GoogleAdsMgr>
{
	private string bannerAdUnitId;

	private string interstitialAdUnitId_1;

	private string interstitialAdUnitId_2;

	private string interstitialAdUnitId_3;

	private string rewardedAdUnitId;

	private string rewardedInterstitialAdUnitId;

	private UnityAction<bool> completeAction;

	private UnityAction callbackAction;

	private bool isRequestingBanner;

	private bool isRequestingInterstitial;

	private bool isShowingInterstitial;

	private int interstitialAdIdx;

	public const int MAX_RELOAD = 3;

	private bool isRequestingRewared;

	private bool isShowingRewared;

	private bool isShowingRewardedInterstitial;

	private bool isRequestingRewardedInterstitial;

	private BannerView _bannerView;

	private InterstitialAd _interstitialAd;

	private RewardedAd _rewardedAd;

	private RewardedInterstitialAd _rewardedInterstitialAd;

	protected override void OnInit()
	{
	}

	public void Start()
	{
	}

	public void CreateBannerView()
	{
	}

	public void LoadBannerAd()
	{
	}

	private void ListenToAdEvents()
	{
	}

	public void DestroyBannerView()
	{
	}

	public void ShowBanner()
	{
	}

	public void HideBanner()
	{
	}

	public void LoadInterstitialAd()
	{
	}

	public void EndLoadInterstitial()
	{
	}

	private string GetInterstitialAdUnitId()
	{
		return null;
	}

	public void ShowInterstitialAd(string placement, UnityAction callback = null)
	{
	}

	private void RegisterEventHandlers(InterstitialAd interstitialAd)
	{
	}

	public void LoadRewardedAd()
	{
	}

	public void ShowRewardedAd(string placement = "", UnityAction<bool> completeAction = null, UnityAction callbackAction = null)
	{
	}

	private void RegisterEventHandlers(RewardedAd ad)
	{
	}

	public void LoadRewardedInterstitialAd()
	{
	}

	public void ShowRewardedInterstitialAd(string placement = "", UnityAction<bool> completeAction = null, UnityAction callbackAction = null)
	{
	}

	private void RegisterEventHandlers(RewardedInterstitialAd ad)
	{
	}

	public void LoadCollapseBanner()
	{
	}
}
