using UnityEngine;

namespace HiGame
{
	public class AdSettings : ScriptableObject
	{
		public static readonly string AD_SETTINGS_ASSET_PATH;

		[Header("APPLOVIN")]
		public bool UsingMax;

		public string SdkKey;

		[Header("Android")]
		public string MaxAndroidBannerID;

		public string MaxAndroidInterstitialID;

		public string MaxAndroidRewardedID;

		public string MaxAndroidMRecID;

		[Header("Ios")]
		public string MaxIOSBannerID;

		public string MaxIOSInterstitialID;

		public string MaxIOSRewardedID;

		public string MaxIOSMRecID;

		public ShowBannerMode ShowBannerMode;

		[Header("IRONSOURCE")]
		public bool UsingIronsource;

		public string AndroidAppKey;

		[SerializeField]
		private string IOSAppKey;

		public bool EnableAdapterDebug;

		public bool EnableIntegrationHelper;

		public bool EnableAdQuality;

		[Tooltip("Add your ad unit id, as provided in Admob")]
		[Header("Android")]
		[Header("APP OPEN AD")]
		public string AndroidAdIDTier1;

		public string AndroidAdIDTier2;

		public string AndroidAdIDTier3;

		[Tooltip("Add your ad unit id, as provided in Admob")]
		[Header("Ios")]
		public string IOSAdIDTier1;

		public string IOSAdIDTier2;

		public string IOSAdIDTier3;

		[Header("ADMOB")]
		public bool UsingAdmob;

		[Header("Android")]
		public string AndroidBannerAdID;

		public string AndroidInterstittialAdID1;

		public string AndroidRewardedAdID;

		public string AndroidRewardedInterstitialAdID;

		public string AndroidNativeAdID;

		[Header("Ios")]
		public string IOSBannerAdID;

		public string IOSInterstittialAdID1;

		public string IOSRewardedAdID;

		public string IOSRewardedInterstitialAdID;

		public string IOSNativeAdID;
	}
}
