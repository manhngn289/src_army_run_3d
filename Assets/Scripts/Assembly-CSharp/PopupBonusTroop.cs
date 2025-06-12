using Aluta;
using TMPro;
using UnityEngine;

public class PopupBonusTroop : PopupSingleton<PopupBonusTroop>
{
	[SerializeField]
	private int[] bonusValue;

	[SerializeField]
	private TMP_Text[] valuesText;

	[SerializeField]
	private Transform spinTroopBonus;

	[SerializeField]
	private Transform spinTroopBonusArrow;

	[SerializeField]
	private CanvasGroup spinTroopBonusGroupAlpha;

	[SerializeField]
	private Transform takeBtn;

	[SerializeField]
	private RectTransform keepBtn;

	[SerializeField]
	private CanvasGroup keepBtnAlpha;

	[SerializeField]
	private TMP_Text troopTakeValueTxt;

	[SerializeField]
	private Transform doubleBtn;

	[SerializeField]
	private CanvasGroup doubleBtnAlpha;

	[SerializeField]
	private GameObject adsGo;

	[SerializeField]
	private GameObject adsTicketGo;

	[SerializeField]
	private GameObject freeGo;

	[SerializeField]
	private TMP_Text adsTicketRequiredTxt;

	[SerializeField]
	private TMP_Text skipAdsTicketAmountTxt;

	private int valueTroop;

	[ReadOnly]
	[SerializeField]
	private bool isDoubleValue;

	[SerializeField]
	private bool isCollectTroop;

	[SerializeField]
	private bool isCollectDoubleTroop;

	protected override void LoadData()
	{
	}

	private void RefreshUI()
	{
	}

	public void TakeTroop()
	{
	}

	public void DoubleValueTroop()
	{
	}

	private void FadeClone()
	{
	}

	private void ShowDoubleBtn()
	{
	}

	public void GetTroopDone()
	{
	}
}
