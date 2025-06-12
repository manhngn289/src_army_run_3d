using UnityEngine;
using UnityEngine.UI;

public class SettingToggleBtn : MonoBehaviour
{
	[SerializeField]
	private Sprite[] settingEnableSp;

	[SerializeField]
	private Sprite[] settingDisableSp;

	[SerializeField]
	private Image iconSetting;

	[SerializeField]
	private SettingType settingType;

	[SerializeField]
	private Color settingOffColor;

	private void OnEnable()
	{
	}

	public void ToggleClick()
	{
	}

	private void ChangeSettingSound()
	{
	}

	private void ChangeSettingMusic()
	{
	}

	private void ChangeSettingVibrate()
	{
	}

	private void RefreshUI(bool isEnable)
	{
	}
}
