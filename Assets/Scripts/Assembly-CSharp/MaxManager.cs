using HiGame;
using UnityEngine;
using UnityEngine.Events;

public class MaxManager : Singleton<MaxManager>
{
	[SerializeField]
	private string SdkKey;

	private string bannerId;

	private string interstitialId;

	private string rewardedId;

	private string mrecId;

	private const int DEFAULT_RETRY_ATTEMPT = 2;

	private int interstitialRetryAttempt;

	private bool isShowingInterstitial;

	private string interstitialPlacement;

	private int rewardedRetryAttempt;

	private bool isShowingRewarded;

	private string rewaredPlacement;

	private int currentLevel;

	private int mrecRetryAttempt;

	private EMRecPosition mrecPosition;

	private UnityAction<bool> completeAction;

	private UnityAction callbackAction;

	public bool IsPortrait => false;

	public bool IsInitialized { get; set; }

	protected override void OnInit()
	{
	}

	public void AsyncInit()
	{
	}

	public void OnSdkInitializedEvent(MaxSdkBase.SdkConfiguration sdkConfiguration)
	{
	}

	public void InitBannerCallback()
	{
	}

	public void OnBannerLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	public void OnBannerLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnBannerAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	public void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnBannerAdExpandedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnBannerAdCollapsedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	public void LoadBanner()
	{
	}

	public void ShowBanner()
	{
	}

	public void HideBanner()
	{
	}

	public void ShowBannerAndRefresh()
	{
	}

	public void RefreshBanner()
	{
	}

	public void InitInterstitialCallback()
	{
	}

	private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	public void LoadInterstitial()
	{
	}

	public void ShowInterstitial(string placement, UnityAction callback = null)
	{
	}

	public void InitRewardedAdCallback()
	{
	}

	private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void LoadRewardedAd()
	{
	}

	public void ShowRewardedAd(string placement, UnityAction<bool> completeAction, UnityAction callbackAction = null)
	{
	}

	public bool IsRewardedReady()
	{
		return false;
	}

	public void InitMRecCallback()
	{
	}

	public void OnMRecAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	public void OnMRecAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo error)
	{
	}

	public void OnMRecAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	public void OnMRecAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	public void OnMRecAdExpandedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	public void OnMRecAdCollapsedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void CreateMRec()
	{
	}

	public void LoadMREC()
	{
	}

	public void ShowMREC()
	{
	}

	public void HideMREC()
	{
	}

	public void UPdateMRecPosition(EMRecPosition mrecPosition)
	{
	}

	public void OnGetRemoteConfig()
	{
	}

	public void UpdateAdConfig(AdConfigData adConfig)
	{
	}
}
