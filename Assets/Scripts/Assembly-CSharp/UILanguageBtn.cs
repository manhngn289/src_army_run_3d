using Everest.CustomEditor;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

public class UILanguageBtn : MonoBehaviour
{
	[DisplayAsString]
	private UIPopupChangeLanguage uIPopupChangeLanguage;

	[DisplayAsString]
	private int localeID;

	[DisplayAsString]
	private Locale locale;

	[SerializeField]
	private TMP_Text localeNameTxt;

	[SerializeField]
	private Image statusImg;

	[SerializeField]
	private GameObject selectedGo;

	[SerializeField]
	private Color[] statusColors;

	public void InitData(int localeID, UIPopupChangeLanguage uIPopupChangeLanguage)
	{
	}

	public void SetView()
	{
	}

	public void ChangeLanguage()
	{
	}
}
