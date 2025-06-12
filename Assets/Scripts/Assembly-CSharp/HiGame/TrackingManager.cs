namespace HiGame
{
	public static class TrackingManager
	{
		private static bool isEnableAppsFlyer;

		private static bool isEnableUnityAnalytics;

		private static bool isEnableFirebase;

		private static ITrackingObject firebaseObject;

		private static ITrackingObject unityAnalyticsObject;

		private static ITrackingObject appsflyerObject;

		public const string INIT_AD = "init_ad";

		public const string AD_IMPRESSION = "ad_impression";

		public const string RECEIVE_FREE_GIFT = "receive_free_gift";

		public const string ADS_REWARD_OFFER = "ad_reward_offer";

		public const string ADS_REWARD_CLICK = "ad_reward_click";

		public const string ADS_REWARD_SHOW = "ad_reward_show";

		public const string ADS_REWARD_SHOW_FAIL = "ad_reward_show_fail";

		public const string ADS_REWARD_LOAD_FAIL = "ad_reward_load_fail";

		public const string ADS_REWARD_TIME_LIMIT = "ad_reward_time_limit";

		public const string ADS_REWARD_COMPLETE = "ad_reward_complete";

		public const string AD_INTER_LOAD_FAIL = "ad_inter_load_fail";

		public const string AD_INTER_SHOW_FAIL = "ad_inter_show_fail";

		public const string AD_INTER_LOAD = "ad_inter_load";

		public const string AD_INTER_SHOW = "ad_inter_show";

		public const string AD_INTER_CLICK = "ad_inter_click";

		public const string AD_INTER_TIME_LIMIT = "ad_inter_time_limit";

		public const string INTER_AD_PUSH_CLICK_ON_OFF = "inter_ad_push_click_on_off";

		public const string TIME_REFRESH_BANNER = "time_refresh_banner";

		public const string ON_OFF_COLLAP = "on_off_collap";

		public const string UNLOCK_BY_REWARDED = "unlock_by_rewarded";

		public const string ID = "id";

		public const string LEVEL = "level";

		public const string DATA = "data";

		public const string ITEM_ID = "item_id";

		public const string NUMBER = "number";

		public const string PLACEMENT = "placement";

		public const string AD_INFO = "ad_info";

		public const string ERROR_MESSSAGE = "error_message";

		public const string AD_PLATFORM = "ad_platform";

		public const string AD_SOURCE = "ad_source";

		public const string AD_UNIT_ID = "ad_unit_name";

		public const string AD_FORMAT = "ad_format";

		public const string VALUE = "value";

		public const string CURRENCY = "currency";

		public static void Init(bool af, bool unityAnalytics, bool firebase)
		{
		}

		public static void SetFirebaseObject(ITrackingObject firebaseObj)
		{
		}

		public static void SetUnityAnalyticsObject(ITrackingObject unityAnalytics)
		{
		}

		public static void SetAppsflyerObject(ITrackingObject appsflyer)
		{
		}

		public static void OnLevelUp(int level)
		{
		}

		public static void OnCompleteTutorial()
		{
		}

		public static void AnalyticsAds(AdUnitType adUnitType, AdEventType adEventType, string placement = "", string errorMsg = "", string addInfo = "")
		{
		}

		public static void AnalyticsEvent(string eventName, string data)
		{
		}

		public static void OnInitIronSourceSDK(string appKey)
		{
		}

		public static void AnalyticsSpendCurrency(int itemId, int number)
		{
		}

		public static void AnalyticsSpendCurrency(string itemId, int number)
		{
		}

		public static void AnalyticsEarnVirtual(int itemId, int number)
		{
		}

		public static void AnalyticsEarnVirtual(string itemId, int number)
		{
		}

		public static void AnalyticsReceiveFreeGift(bool x2)
		{
		}

		public static void SetUserID(string userId)
		{
		}

		public static void AnalyticsEventWithParameter(string name, params MParameter[] parameters)
		{
		}

		public static void AnalyticsEventWithParameter(string name, TrackingMode mode, params MParameter[] parameters)
		{
		}

		public static void AnalyticsAdRevenue(EMediationType mediationType, string network, string adId, string adType, string adPlacement, double revenue, string currency)
		{
		}
	}
}
