using Aluta;
using UnityEngine;

public class PauseGameManager : Singleton<PauseGameManager>
{
	public static bool IsGamePause;

	[StaticSerialize("IsGamePause")]
	[SerializeField]
	private bool isPauseGame;

	private static Coroutine slowTimeToStopCor;

	public void NormalTime()
	{
	}

	public static void StopTime()
	{
	}

	public void SlowTimeToStop(float timeScaleSlow, float durationSlow)
	{
	}
}
