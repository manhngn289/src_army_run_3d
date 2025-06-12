using Firebase;

namespace HiGame
{
	public class FirebaseAnalyticsObj : Singleton<FirebaseAnalyticsObj>, ITrackingObject
	{
		private FirebaseApp app;

		private bool firebaseInitialized;

		public bool IsCheckingDependency { get; private set; }

		public bool IsInitialized => false;

		protected override void OnInit()
		{
		}

		public void AsyncInit()
		{
		}

		private void InitializeFirebase()
		{
		}

		public void AnalyticsCompleteTutorial()
		{
		}

		public void AnalyticsAds(AdUnitType adUnitType, AdEventType adEventType, string placement = "", string errorMsg = "", string addInfo = "")
		{
		}

		public void AnalyticsInitIronSourceSDK(string appKey)
		{
		}

		public void AnalyticsEvent(string eventName, string data)
		{
		}

		public void AnalyticsLevelUp(int level)
		{
		}

		public void AnalyticsEarnVirtual(int itemId, int number)
		{
		}

		public void AnalyticsSpendVirtual(int itemId, int number)
		{
		}

		public void AnalyticsEarnVirtual(string itemId, int number)
		{
		}

		public void AnalyticsSpendVirtual(string itemId, int number)
		{
		}

		public void AnalyticsReceiveFreeGift(bool x2)
		{
		}

		public void SetUserID(string userId)
		{
		}

		public void AnalyticsEventWithParameter(string name, params MParameter[] args)
		{
		}

		public void AnalyticsAdRevenue(EMediationType mediationType, string network, string adId, string adType, string adPlacement, double revenue, string currency)
		{
		}
	}
}
