using Aluta;
using Everest.CustomEditor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupWinLose : PopupSingleton<PopupWinLose>
{
	public static int GoldClaimInLevel;

	public static int ElixirClaimInLevel;

	public static bool IsWin;

	[SerializeField]
	[ReadOnly]
	private float multiplyRewardValue;

	[SerializeField]
	private Image titleImg;

	[SerializeField]
	private Sprite[] titleSprites;

	[SerializeField]
	private Image bgGradientImg;

	[SerializeField]
	private Sprite[] winLoseGradientBgSprites;

	[SerializeField]
	private TMP_Text coinRewardTxt;

	[SerializeField]
	private TMP_Text elixirRewardTxt;

	[SerializeField]
	private Transform getMultiRewardBtn;

	[SerializeField]
	private Transform[] multiplyValueTR;

	[SerializeField]
	private float[] multiplyValue;

	[SerializeField]
	private Transform arrowMultiplierTR;

	[SerializeField]
	private Transform rotateArrowMultiplierTR;

	[SerializeField]
	private GameObject nextBtnSmallGo;

	[SerializeField]
	private GameObject multiRewardGo;

	[SerializeField]
	private CanvasGroup nextBtnBigAlpha;

	[SerializeField]
	private Color[] multiRewardColors;

	[SerializeField]
	private CanvasGroup goldMultiplierValueAlpha;

	[SerializeField]
	private CanvasGroup elixirMultiplierValueAlpha;

	[SerializeField]
	private TMP_Text goldMultiplierValueTxt;

	[SerializeField]
	private TMP_Text goldMultiplierValueShadowTxt;

	[SerializeField]
	private TMP_Text elixirMultiplierValueTxt;

	[SerializeField]
	private TMP_Text elixirMultiplierValueShadowTxt;

	[SerializeField]
	private GameObject adsReward;

	[SerializeField]
	private GameObject ticketReward;

	[SerializeField]
	private GameObject freeReward;

	[SerializeField]
	private TMP_Text ticketAdsQuantityTxt;

	[ReadOnly]
	public int rewardCoin;

	[ReadOnly]
	public int rewardElixir;

	[ReadOnly]
	[SerializeField]
	private bool showInter;

	[SerializeField]
	private AnimationCurve scaleCurve;

	public bool isShowingBigNextBtn;

	[SerializeField]
	private float scaleTIme;

	[SerializeField]
	private float fadeTIme;

	[SerializeField]
	private float delayTIme;

	protected override void LoadData()
	{
	}

	public void OnWinLoseShowDone()
	{
	}

	private void MultiplyRewardValue()
	{
	}

	[Button(null)]
	public void GetMultiRewardBtnClick()
	{
	}

	private void GetMultiReward()
	{
	}

	private void MultiRewardAnim(int minId, int rewardGoldMulti, int rewardElixirMulti)
	{
	}

	private void ShowNextBigBtn()
	{
	}

	private void HideDefaultBtn()
	{
	}

	public void NoThankBtnClick()
	{
	}

	public override void HidePopup()
	{
	}
}
