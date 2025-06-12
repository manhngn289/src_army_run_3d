using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace HiGame
{
	public class AdManager : Singleton<AdManager>
	{
		[CompilerGenerated]
		private sealed class _003CDoRefreshBanner_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdManager _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoRefreshBanner_003Ed__50(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public static bool pauseInGame;

		public static bool isNoAds;

		private static bool isHideBanner;

		private static int DEFAULT_INTERSTITIAL_INTERVAL;

		private static int interstitialInterval;

		private static DateTime lastShowInterstialTime;

		public static DateTime lastCloseInterstitialTime;

		private static AdConfigData adConfig;

		private static DateTime callcollapseBannerTime;

		private static ShowBannerMode showBannerMode;

		private bool isFirstTimeShowBanner;

		private DateTime timeOutGame;

		private AdSettings adSetting;

		public static bool HasJustShowAds { get; set; }

		public static bool IsHideBanner => false;

		public static int InterstitialInterval
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static AdConfigData AdConfig => null;

		public static bool IsPortrait => false;

		public bool IsShowingInterstitial { get; set; }

		public bool IsShowingRewared { get; set; }

		public bool IsShowingAOA { get; set; }

		protected override void OnInit()
		{
		}

		public void AsyncInit()
		{
		}

		public void ShowRewardedVideoAd(string placement, UnityAction<bool> completeAction = null, UnityAction callbackAction = null)
		{
		}

		public bool IsRewardedReady()
		{
			return false;
		}

		public void ShowInterstitialAd(string placement, UnityAction callbackAction = null)
		{
		}

		public void ShowAppOpenAd()
		{
		}

		public void ShowBanner()
		{
		}

		public void ShowMediationBanner()
		{
		}

		public void ShowMediationBannerAndRefresh()
		{
		}

		public void ShowCollapBanner()
		{
		}

		public void RefreshBanner()
		{
		}

		public void ShowBannerCor()
		{
		}

		[IteratorStateMachine(typeof(_003CDoRefreshBanner_003Ed__50))]
		public IEnumerator DoRefreshBanner()
		{
			return null;
		}

		public void HideBanner()
		{
		}

		public void ShowRewardedInterstitialAd(string placement, UnityAction<bool> completeAction = null, UnityAction callbackAction = null)
		{
		}

		public void OnCloseInterstitialAd()
		{
		}

		public void ShowMRec()
		{
		}

		public void OnRewaredOffer(string rewaredPlacement)
		{
		}

		public void UpdateRemoteConfig(FirebaseRemoteData data)
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		public void RemoveAd()
		{
		}
	}
}
