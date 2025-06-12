using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupUnlockSkinCongratulations : PopupSingleton<PopupUnlockSkinCongratulations>
{
	[SerializeField]
	private Button closeBtn;

	[SerializeField]
	private TMP_Text skinNameTxt;

	[SerializeField]
	private TMP_Text skinNameUnderlayTxt;

	protected override void LoadData()
	{
	}

	private void OnEnable()
	{
	}

	private void SetData()
	{
	}

	private void DelayCloseBtn()
	{
	}

	public override void HidePopup()
	{
	}
}
