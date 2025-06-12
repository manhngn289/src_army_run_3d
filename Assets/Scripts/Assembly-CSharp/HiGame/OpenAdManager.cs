using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine;

namespace HiGame
{
	[AddComponentMenu("GoogleMobileAds/Samples/AppOpenAdController")]
	public class OpenAdManager : Singleton<OpenAdManager>
	{
		[CompilerGenerated]
		private sealed class _003CReloadAd_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OpenAdManager _003C_003E4__this;

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
			public _003CReloadAd_003Ed__24(int _003C_003E1__state)
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

		private GameObject AdLoadedStatus;

		private string adUnitId_1;

		private readonly TimeSpan TIMEOUT;

		private DateTime expireTime;

		private DateTime lastTimeShow;

		private AppOpenAd appOpenAd;

		private int adIndex;

		private string currentAdsId;

		private bool isFirstTime;

		private bool isRequesting;

		private bool isShowingAd;

		public DateTime LastTimeShow => default(DateTime);

		protected override void OnInit()
		{
		}

		private void Start()
		{
		}

		private void OnAppStateChanged(AppState state)
		{
		}

		public void LoadAd()
		{
		}

		public void OnLoadAdComplete(AppOpenAd ad, LoadAdError error)
		{
		}

		private void EndLoadAd()
		{
		}

		private string GetAdUnitId()
		{
			return null;
		}

		public void ShowAd()
		{
		}

		public void DestroyAd()
		{
		}

		public void LogResponseInfo()
		{
		}

		private void RegisterEventHandlers(AppOpenAd ad)
		{
		}

		[IteratorStateMachine(typeof(_003CReloadAd_003Ed__24))]
		private IEnumerator ReloadAd()
		{
			return null;
		}

		public void UpdateAdId(string adId)
		{
		}
	}
}
