using UnityEngine;
using UnityEngine.Events;

namespace HiGame
{
	public class IronSourceManager : MonoBehaviour
	{
		private bool isDevelopment;

		private bool isIntegrationHelper;

		private bool isEnableAdQuality;

		private string APP_KEY;

		private int numLoadBannerFailed;

		private int numLoadInterstitialFail;

		private int numLoadRewardedFail;

		private const int MAX_NUM_LOAD_BANNER_FAILED = 3;

		private const int MAX_NUM_LOAD_INTERSTITILA_FAILED = 2;

		private const int MAX_NUM_LOAD_REWARDED_FAILED = 2;

		private const int TIME_TO_RELOAD_AD = 20;

		private UnityAction<bool> completeAction;

		private UnityAction callbackAction;

		private bool isLoadingBanner;

		private bool isLoadingInterstitial;

		private bool isLoadingReward;

		public static IronSourceManager Instance { get; private set; }
	}
}
