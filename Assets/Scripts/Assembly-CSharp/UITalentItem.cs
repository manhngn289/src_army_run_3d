using Everest.CustomEditor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UITalentItem : MonoBehaviour
{
	[DisplayAsString]
	private PopupTalent popupTalent;

	[SerializeField]
	private Image talentIconImg;

	[SerializeField]
	private Image talentIconNotUnlockImg;

	[SerializeField]
	private Image talentSelectedOutlineGO;

	[SerializeField]
	private TMP_Text talentLevelTxt;

	[SerializeField]
	private GameObject talentUnlockedGO;

	[SerializeField]
	private GameObject notUnlockOverlayGO;

	[SerializeField]
	private UIAnimation_TalentItem talentItemAnim;

	public TalentData talentData;

	public void SetData(TalentData talentData, PopupTalent popupTalent)
	{
	}

	private void RefreshUI()
	{
	}

	public void UnlockTalent()
	{
	}

	public void UpgradeTalent()
	{
	}

	public void ActiveSelectOutline(bool isImmediate)
	{
	}

	public void DeactiveSelectOutline(bool isImmediate)
	{
	}

	public void TalentSelected()
	{
	}
}
