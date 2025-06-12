using GoogleMobileAds.Ump.Api;
using HiGame;
using UnityEngine;

namespace Game
{
	public class GDPRScript : Singleton<GDPRScript>
	{
		public bool ShowGDPRPopupDone;

		[SerializeField]
		private bool test;

		private void Start()
		{
		}

		public void CallGDPR()
		{
		}

		private void OnConsentInfoUpdated(FormError consentError)
		{
		}

		private void InitADS()
		{
		}

		public static string GetDeviceID()
		{
			return null;
		}
	}
}
