using HiGame.Core.Utils;
using UnityEngine;
using UnityEngine.Purchasing;

namespace HiGame
{
	public class IapAppsFlyerAnalyticsObj : HiGame.Core.Utils.Singleton<IapAppsFlyerAnalyticsObj>
	{
		[SerializeField]
		private string licenseKey;

		public void AppsFlyerPurchaseEvent(Product product, int quantity = 1)
		{
		}

		private static string GetAppsflyerRevenue(decimal amount)
		{
			return null;
		}

		public void ProcessPurchase(PurchaseEventArgs args)
		{
		}

		public void didFinishValidateReceipt(string result)
		{
		}

		public void didFinishValidateReceiptWithError(string error)
		{
		}
	}
}
