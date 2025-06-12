using System.Collections.Generic;
using Aluta;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
	private class AudioNonDuplicate
	{
		public float MinTimeBetweenPlay;

		public float LastTimePlayed;
	}

	[Header("Gameplay")]
	public AudioClip[] battleNormalBGMusic;

	public AudioClip[] battleRunCoinBGMusic;

	public AudioClip homeBGMusic;

	public AudioClip bossBGMusic;

	public AudioClip win;

	public AudioClip lose;

	public AudioClip evolve;

	public AudioClip troopSpawn;

	public AudioClip gate;

	public AudioClip collectCoin;

	public AudioClip collectElixir;

	public AudioClip collectKey;

	public AudioClip troopDead;

	public AudioClip upgradeTroop;

	public AudioClip shop;

	public AudioClip utilityDoor;

	public AudioClip utilityPowerup;

	public AudioClip[] fallingMeteors;

	public AudioClip troopTouchGround;

	public AudioClip explosion;

	public AudioClip explosionMissle;

	public AudioClip[] explosionDebris;

	[Header("UI")]
	public AudioClip buttonNormal;

	public AudioClip talentRandom;

	public AudioClip chooseTalent;

	private static readonly Dictionary<AudioClip, AudioNonDuplicate> SoundMinTimePlay;

	protected override void Awake()
	{
	}

	public static void SetMusic(bool enabled)
	{
	}

	public static void SetSound(bool enabled)
	{
	}

	public static void PlaySound(AudioClip audioClip)
	{
	}

	public static void PlaySound(AudioClip audioClip, float volume)
	{
	}

	public static void PlaySound(AudioClip audioClip, float volume, bool loop, Transform source)
	{
	}

	public static int PlaySoundAndReturnID(AudioClip audioClip, float volume, bool loop, Transform source)
	{
		return 0;
	}

	public static void PlayUISound(AudioClip audioClip)
	{
	}

	public static void PlayUISound(AudioClip audioClip, float volume)
	{
	}

	public static void StopSound(AudioClip audioClip)
	{
	}

	public static void StopSound(int audioID)
	{
	}

	public static void StopAllSound()
	{
	}

	public static void PlayMusic(AudioClip audioClip)
	{
	}

	public static void StopAllMusic(float fadeOffTime)
	{
	}

	private static void PlayMusic(AudioClip audioClip, float volume)
	{
	}

	public static void PlayNormalClick()
	{
	}

	public void ChangeMusic(AudioClip fromClip, AudioClip toClip, float duration)
	{
	}

	public static void OffAllMusicAndPlayNew(AudioClip clipPlay, float volume, float fadeOffTime = -1f)
	{
	}

	public void FadeVolumeMusic(AudioClip audioClip, float startVolume, float endVolume, float duration, bool wantToPause = true)
	{
	}

	public void FadeVolumeSound(AudioClip audioClip, float startVolume, float endVolume, float duration, bool wantToPause = true)
	{
	}

	public void FadeVolumeSound(int audioID, float startVolume, float endVolume, float duration, bool wantToPause = true)
	{
	}

	public void PlaySoundDelay(AudioClip audioClip, float delayTime)
	{
	}

	public void PlaySoundDelay(AudioClip audioClip, float volume, float delayTime)
	{
	}

	public static void PlaySoundPreventSame(AudioClip clipPlay, float volume, float minTimePlaySameSound)
	{
	}

	public static void PlayUISoundPreventSame(AudioClip clipPlay, float volume, float minTimePlaySameSound)
	{
	}
}
