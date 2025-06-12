public static class SettingData
{
	private const string SOUND_ENABLE = "SoundEnable";

	private const string MUSIC_ENABLE = "MusicEnable";

	private const string VIBRATE_ENABLE = "VibrateEnable";

	public static bool SoundEnable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool MusicEnable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool VibrateEnable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool GetValueSetting(SettingType settingType)
	{
		return false;
	}
}
