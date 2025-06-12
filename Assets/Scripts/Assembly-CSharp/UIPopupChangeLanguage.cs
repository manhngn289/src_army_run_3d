using System.Collections.Generic;
using UnityEngine;

public class UIPopupChangeLanguage : PopupSingleton<UIPopupChangeLanguage>
{
	[SerializeField]
	private List<UILanguageBtn> uILanguageBtns;

	private bool isInited;

	private void OnEnable()
	{
	}

	protected override void LoadData()
	{
	}

	private void Init()
	{
	}

	public void RefreshView()
	{
	}
}
