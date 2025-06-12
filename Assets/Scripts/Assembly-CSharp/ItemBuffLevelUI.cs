using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemBuffLevelUI : MonoBehaviour
{
	[FormerlySerializedAs("itemBGSprites")]
	[SerializeField]
	private Sprite[] itemBgSprites;

	[SerializeField]
	private Sprite[] itemBgBackSprites;

	[SerializeField]
	private Color[] itemTxtColors;

	[SerializeField]
	private TMP_Text buffNameTxt;

	[SerializeField]
	private TMP_Text buffDescriptionTxt;

	[SerializeField]
	private GameObject[] buffIcons;

	[FormerlySerializedAs("itemBGImg")]
	[SerializeField]
	private Image itemBgImg;

	[SerializeField]
	private Image itemBgBackImg;

	[FormerlySerializedAs("itemSelectedGO")]
	[SerializeField]
	private GameObject itemSelectedGo;

	[SerializeField]
	private GameObject adsGo;

	[SerializeField]
	private GameObject ticketAdsGo;

	[SerializeField]
	private Image epicGlowImg;

	[SerializeField]
	private UIAnimation_LevelBuffItem uiAnimationLevelBuffItem;

	private BaseLevelBuffSO itemBuff;

	private PopupBuffLevel popupBuffLevel;

	public void SetData(BaseLevelBuffSO levelBuff, PopupBuffLevel popupBuffLevelManager)
	{
	}

	public void GetBuffSelected(bool hidePopup = false)
	{
	}

	public void HideItem()
	{
	}
}
