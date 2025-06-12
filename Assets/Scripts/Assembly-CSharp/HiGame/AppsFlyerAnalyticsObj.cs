using UnityEngine.Purchasing;

namespace HiGame
{
	public class AppsFlyerAnalyticsObj : Singleton<AppsFlyerAnalyticsObj>, ITrackingObject
	{
		protected override void OnInit()
		{
		}

		public void AnalyticsAdRevenue(EMediationType mediationType, string network, string adId, string adType, string adPlacement, double revenue, string currency)
		{
		}

		public void AnalyticsAds(AdUnitType adUnitType, AdEventType adEventType, string placement = "", string errorMsg = "", string addInfo = "")
		{
		}

		public void AnalyticsCompleteTutorial()
		{
		}

		public void AnalyticsEarnVirtual(int itemId, int number)
		{
		}

		public void AnalyticsEarnVirtual(string itemId, int number)
		{
		}

		public void AnalyticsEvent(string eventName, string data)
		{
		}

		public void AnalyticsEventWithParameter(string name, params MParameter[] parameters)
		{
		}

		public void AnalyticsInitIronSourceSDK(string appKey)
		{
		}

		public void AnalyticsLevelUp(int level)
		{
		}

		public void AnalyticsReceiveFreeGift(bool x2)
		{
		}

		public void AnalyticsSpendVirtual(int itemId, int number)
		{
		}

		public void AnalyticsSpendVirtual(string itemId, int number)
		{
		}

		public void SetUserID(string userId)
		{
		}

		public void AppsFlyerPurchaseEvent(Product product)
		{
		}

		public static string GetAppsflyerRevenue(decimal amount)
		{
			return null;
		}
	}
}
