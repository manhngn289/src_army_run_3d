using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class SettingUI : MonoBehaviour
{
	[ReadOnly]
	[SerializeField]
	private bool isShowingSetting;

	[SerializeField]
	private GameObject[] items;

	private void Start()
	{
	}

	public void SettingBtnClick()
	{
	}

	[Button(null)]
	private void HideSetting(bool immediate = false)
	{
	}

	[Button(null)]
	private void ShowSetting()
	{
	}
}
