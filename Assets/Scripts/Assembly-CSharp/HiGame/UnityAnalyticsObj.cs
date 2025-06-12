using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HiGame
{
	public class UnityAnalyticsObj : Singleton<UnityAnalyticsObj>, ITrackingObject
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnInit_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[AsyncStateMachine(typeof(_003COnInit_003Ed__0))]
		protected override void OnInit()
		{
		}

		public void AnalyticsCompleteTutorial()
		{
		}

		public void AnalyticsLevelUp(int level)
		{
		}

		public void AnalyticsAds(AdUnitType adUnitType, AdEventType adEventType, string placement = "", string errorMsg = "", string addInfo = "")
		{
		}

		public void AnalyticsEvent(string eventName, string data)
		{
		}

		public void AnalyticsInitIronSourceSDK(string appKey)
		{
		}

		public void AnalyticsEarnVirtual(int itemId, int number)
		{
		}

		public void AnalyticsSpendVirtual(int itemId, int number)
		{
		}

		public void AnalyticsReceiveFreeGift(bool x2)
		{
		}

		public void SetUserID(string userId)
		{
		}

		public void AnalyticsEarnVirtual(string itemId, int number)
		{
		}

		public void AnalyticsSpendVirtual(string itemId, int number)
		{
		}

		public void AnalyticsEventWithParameter(string name, params MParameter[] parameters)
		{
		}

		public void AnalyticsAdRevenue(EMediationType mediationType, string network, string adId, string adType, string adPlacement, double revenue, string currency)
		{
		}
	}
}
