using UnityEngine;

namespace Hellmade.Sound
{
	public class Audio
	{
		public enum AudioType
		{
			Music = 0,
			Sound = 1,
			UISound = 2
		}

		private static int audioCounter;

		private AudioClip clip;

		private bool loop;

		private bool mute;

		private int priority;

		private float pitch;

		private float stereoPan;

		private float spatialBlend;

		private float reverbZoneMix;

		private float dopplerLevel;

		private float spread;

		private AudioRolloffMode rolloffMode;

		private float max3DDistance;

		private float min3DDistance;

		private float targetVolume;

		private float initTargetVolume;

		private float tempFadeSeconds;

		private float fadeInterpolater;

		private float onFadeStartVolume;

		private Transform sourceTransform;

		public int AudioID { get; private set; }

		public AudioType Type { get; private set; }

		public bool IsPlaying { get; private set; }

		public bool Paused { get; private set; }

		public bool Stopping { get; private set; }

		public bool Activated { get; private set; }

		public bool Pooled { get; set; }

		public float Volume { get; private set; }

		public AudioSource AudioSource { get; private set; }

		public Transform SourceTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AudioClip Clip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Mute
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Priority
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float Pitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StereoPan
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SpatialBlend
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ReverbZoneMix
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float DopplerLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Spread
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AudioRolloffMode RolloffMode
		{
			get
			{
				return default(AudioRolloffMode);
			}
			set
			{
			}
		}

		public float Max3DDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Min3DDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Persist { get; set; }

		public float FadeInSeconds { get; set; }

		public float FadeOutSeconds { get; set; }

		public Audio(AudioType audioType, AudioClip clip, bool loop, bool persist, float volume, float fadeInValue, float fadeOutValue, Transform sourceTransform)
		{
		}

		private void CreateAudiosource()
		{
		}

		public void Play()
		{
		}

		public void Play(float volume)
		{
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public void UnPause()
		{
		}

		public void Resume()
		{
		}

		public void SetVolume(float volume)
		{
		}

		public void SetVolume(float volume, float fadeSeconds)
		{
		}

		public void SetVolume(float volume, float fadeSeconds, float startVolume)
		{
		}

		public void Set3DDistances(float min, float max)
		{
		}

		public void Update()
		{
		}
	}
}
