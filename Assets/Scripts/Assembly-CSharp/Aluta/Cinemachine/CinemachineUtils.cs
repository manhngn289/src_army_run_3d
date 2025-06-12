using System;
using Cinemachine;
using UnityEngine;

namespace Aluta.Cinemachine
{
	public static class CinemachineUtils
	{
		public static void InvokeActionOnChangeCamDone(this CinemachineVirtualCamera fromCam, CinemachineVirtualCamera toCam, string changeCamDone, MonoBehaviour invokeTarget)
		{
		}

		public static void InvokeActionOnChangeCamDone(this CinemachineVirtualCamera fromCam, CinemachineVirtualCamera toCam, Action changeCamDone)
		{
		}

		public static CinemachineBlenderSettings.CustomBlend FindCustomBlendWithCamName(this CinemachineBlenderSettings blendSettings, CinemachineVirtualCamera fromCam, CinemachineVirtualCamera toCam)
		{
			return default(CinemachineBlenderSettings.CustomBlend);
		}

		private static bool IsBlendAToB(CinemachineBlenderSettings.CustomBlend blendCheck, string fromCam, string toCam)
		{
			return false;
		}
	}
}
