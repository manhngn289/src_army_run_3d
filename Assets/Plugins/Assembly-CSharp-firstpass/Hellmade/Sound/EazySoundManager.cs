using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Hellmade.Sound
{
	public class EazySoundManager : MonoBehaviour
	{
		private static EazySoundManager instance;

		private static Dictionary<int, Audio> musicAudio;

		private static Dictionary<int, Audio> soundsAudio;

		private static Dictionary<int, Audio> UISoundsAudio;

		private static Dictionary<int, Audio> audioPool;

		private static bool initialized;

		public static GameObject Gameobject => null;

		public static bool IgnoreDuplicateMusic { get; set; }

		public static bool IgnoreDuplicateSounds { get; set; }

		public static bool IgnoreDuplicateUISounds { get; set; }

		public static float GlobalVolume { get; set; }

		public static float GlobalMusicVolume { get; set; }

		public static float GlobalSoundsVolume { get; set; }

		public static float GlobalUISoundsVolume { get; set; }

		private static EazySoundManager Instance => null;

		static EazySoundManager()
		{
		}

		private void Init()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		private void Update()
		{
		}

		private static Dictionary<int, Audio> GetAudioTypeDictionary(Audio.AudioType audioType)
		{
			return null;
		}

		private static bool GetAudioTypeIgnoreDuplicateSetting(Audio.AudioType audioType)
		{
			return false;
		}

		private static void UpdateAllAudio(Dictionary<int, Audio> audioDict)
		{
		}

		private static void RemoveNonPersistAudio(Dictionary<int, Audio> audioDict)
		{
		}

		public static bool RestoreAudioFromPool(Audio.AudioType audioType, int audioID)
		{
			return false;
		}

		public static Audio GetAudio(int audioID)
		{
			return null;
		}

		public static Audio GetAudio(AudioClip audioClip)
		{
			return null;
		}

		public static Audio GetMusicAudio(int audioID)
		{
			return null;
		}

		public static Audio GetMusicAudio(AudioClip audioClip)
		{
			return null;
		}

		public static Audio GetSoundAudio(int audioID)
		{
			return null;
		}

		public static Audio GetSoundAudio(AudioClip audioClip)
		{
			return null;
		}

		public static Audio GetUISoundAudio(int audioID)
		{
			return null;
		}

		public static Audio GetUISoundAudio(AudioClip audioClip)
		{
			return null;
		}

		private static Audio GetAudio(Audio.AudioType audioType, bool usePool, int audioID)
		{
			return null;
		}

		private static Audio GetAudio(Audio.AudioType audioType, bool usePool, AudioClip audioClip)
		{
			return null;
		}

		public static int PrepareMusic(AudioClip clip)
		{
			return 0;
		}

		public static int PrepareMusic(AudioClip clip, float volume)
		{
			return 0;
		}

		public static int PrepareMusic(AudioClip clip, float volume, bool loop, bool persist)
		{
			return 0;
		}

		public static int PrepareMusic(AudioClip clip, float volume, bool loop, bool persist, float fadeInSeconds, float fadeOutSeconds)
		{
			return 0;
		}

		public static int PrepareMusic(AudioClip clip, float volume, bool loop, bool persist, float fadeInSeconds, float fadeOutSeconds, float currentMusicfadeOutSeconds, Transform sourceTransform)
		{
			return 0;
		}

		public static int PrepareSound(AudioClip clip)
		{
			return 0;
		}

		public static int PrepareSound(AudioClip clip, float volume)
		{
			return 0;
		}

		public static int PrepareSound(AudioClip clip, bool loop)
		{
			return 0;
		}

		public static int PrepareSound(AudioClip clip, float volume, bool loop, Transform sourceTransform)
		{
			return 0;
		}

		public static int PrepareUISound(AudioClip clip)
		{
			return 0;
		}

		public static int PrepareUISound(AudioClip clip, float volume)
		{
			return 0;
		}

		private static int PrepareAudio(Audio.AudioType audioType, AudioClip clip, float volume, bool loop, bool persist, float fadeInSeconds, float fadeOutSeconds, float currentMusicfadeOutSeconds, Transform sourceTransform)
		{
			return 0;
		}

		public static int PlayMusic(AudioClip clip)
		{
			return 0;
		}

		public static int PlayMusic(AudioClip clip, float volume)
		{
			return 0;
		}

		public static int PlayMusic(AudioClip clip, float volume, bool loop, bool persist)
		{
			return 0;
		}

		public static int PlayMusic(AudioClip clip, float volume, bool loop, bool persist, float fadeInSeconds, float fadeOutSeconds)
		{
			return 0;
		}

		public static int PlayMusic(AudioClip clip, float volume, bool loop, bool persist, float fadeInSeconds, float fadeOutSeconds, float currentMusicfadeOutSeconds, Transform sourceTransform)
		{
			return 0;
		}

		public static int PlaySound(AudioClip clip)
		{
			return 0;
		}

		public static int PlaySound(AudioClip clip, float volume)
		{
			return 0;
		}

		public static int PlaySound(AudioClip clip, bool loop)
		{
			return 0;
		}

		public static int PlaySound(AudioClip clip, float volume, bool loop, Transform sourceTransform)
		{
			return 0;
		}

		public static int PlayUISound(AudioClip clip)
		{
			return 0;
		}

		public static int PlayUISound(AudioClip clip, float volume)
		{
			return 0;
		}

		private static int PlayAudio(Audio.AudioType audioType, AudioClip clip, float volume, bool loop, bool persist, float fadeInSeconds, float fadeOutSeconds, float currentMusicfadeOutSeconds, Transform sourceTransform)
		{
			return 0;
		}

		public static void StopAll()
		{
		}

		public static void StopAll(float musicFadeOutSeconds)
		{
		}

		public static void StopAllMusic()
		{
		}

		public static void StopAllMusic(float fadeOutSeconds)
		{
		}

		public static void StopAllSounds()
		{
		}

		public static void StopAllUISounds()
		{
		}

		private static void StopAllAudio(Audio.AudioType audioType, float fadeOutSeconds)
		{
		}

		public static void PauseAll()
		{
		}

		public static void PauseAllMusic()
		{
		}

		public static void PauseAllSounds()
		{
		}

		public static void PauseAllUISounds()
		{
		}

		private static void PauseAllAudio(Audio.AudioType audioType)
		{
		}

		public static void ResumeAll()
		{
		}

		public static void ResumeAllMusic()
		{
		}

		public static void ResumeAllSounds()
		{
		}

		public static void ResumeAllUISounds()
		{
		}

		private static void ResumeAllAudio(Audio.AudioType audioType)
		{
		}
	}
}
