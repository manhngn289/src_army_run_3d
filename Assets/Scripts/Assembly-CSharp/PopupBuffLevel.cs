using System.Collections.Generic;
using Aluta;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupBuffLevel : PopupSingleton<PopupBuffLevel>
{
	[SerializeField]
	private AllLevelBuffSO allBuffSO;

	[SerializeField]
	private AllLevelBuffSO allRunBuffSO;

	[SerializeField]
	private ItemBuffLevelUI[] itemBuffLevels;

	[SerializeField]
	private GameObject reRollFree;

	[SerializeField]
	private GameObject reRollAds;

	[SerializeField]
	private GameObject reRollTicketAds;

	[SerializeField]
	private TMP_Text adsTicketQuantityTxt;

	[SerializeField]
	private CanvasGroup adsTicketQuantityAlpha;

	[SerializeField]
	private CanvasGroup titleAlpha;

	[SerializeField]
	private CanvasGroup reRollBtnAlpha;

	[SerializeField]
	private GameObject blockInteract;

	[SerializeField]
	[ReadOnly]
	private bool isInitialized;

	[ReadOnly]
	[SerializeField]
	private List<BaseLevelBuffSO> epicBuff;

	[ReadOnly]
	[SerializeField]
	private List<BaseLevelBuffSO> rareBuff;

	[SerializeField]
	[ReadOnly]
	private List<BaseLevelBuffSO> runLevelBuff;

	[SerializeField]
	[ReadOnly]
	private List<BaseLevelBuffSO> epicBuffExcept;

	[ReadOnly]
	[SerializeField]
	private List<BaseLevelBuffSO> rareBuffExcept;

	[SerializeField]
	private HorizontalLayoutGroup itemGroup;

	protected override void LoadData()
	{
	}

	private void RandomBuff()
	{
	}

	public void ReRoll()
	{
	}

	public void SelectBuffAnim(ItemBuffLevelUI itemSelected)
	{
	}

	public void RefreshUI()
	{
	}
}
