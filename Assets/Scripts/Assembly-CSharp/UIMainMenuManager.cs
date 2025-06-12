using System;
using System.Collections.Generic;
using Everest.CustomEditor;
using HG.Rate;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIMainMenuManager : PopupManager<UIMainMenuManager>
{
	public List<MonoBehaviour> popupActived;

	public Transform[] ignoreSafeAreaPos;

	public CanvasGroup allCanvasGroup;

	public Joystick joystick;

	public TopUIManager topUIManager;

	public bool isHidingUI;

	[FormerlySerializedAs("globalCoin")]
	[SerializeField]
	private CanvasGroup globalResources;

	[SerializeField]
	private GameObject globalCoin;

	[SerializeField]
	private GameObject globalElixir;

	[SerializeField]
	private GameObject globalAdsTicket;

	[SerializeField]
	private TMP_Text goldTxt;

	[SerializeField]
	private TMP_Text elixirTxt;

	[SerializeField]
	private TMP_Text adsTicketTxt;

	[SerializeField]
	private GlobalResourceShower coinShower;

	[SerializeField]
	private GlobalResourceShower elixirShower;

	[SerializeField]
	private GlobalResourceShower adsTicketShower;

	public Image fadeLevelImg;

	public PopupHome popupHome;

	public PopupWinLose popupWinLose;

	public GameObject winLoseCam;

	[FormerlySerializedAs("winloseTroopPreviewAnimation")]
	[FormerlySerializedAs("playerHomeAnimation")]
	[SerializeField]
	private PlayerHomeAnimationController winLoseTroopPreviewAnimation;

	[SerializeField]
	private PopupBuffLevel popupLevelBuff;

	[SerializeField]
	private PopupTalent popupTalent;

	[SerializeField]
	private PopupRevive popupRevive;

	[SerializeField]
	private PopupPause popupPause;

	[SerializeField]
	private PopupDelayContinueGame popupDelayContinueGame;

	[SerializeField]
	private Image loseTroopWarning;

	[SerializeField]
	private float timeFadeWarning;

	[SerializeField]
	private PopupSetting popupSetting;

	[SerializeField]
	private UIPopupChangeLanguage uiPopupChangeLanguage;

	[SerializeField]
	private PopupBonusTroop popupBonusTroop;

	[SerializeField]
	private PopupStarterPack popupStarterPack;

	[SerializeField]
	private PopupNoAdsPack popupNoAdsPack;

	private Coroutine waitActiveHomeAndShowIAPPack;

	[SerializeField]
	private UIShopManager uiShopManager;

	[SerializeField]
	private RateManager popupRatePrefab;

	[SerializeField]
	private PopupSkin popupSkinPrefab;

	[SerializeField]
	private PopupUnlockSkinProgress popupUnlockSkinProgressPrefab;

	[SerializeField]
	private PopupUnlockSkinCongratulations popupUnlockSkinCongratulations;

	[FormerlySerializedAs("troopPreviewEvolveGo")]
	[SerializeField]
	public GameObject troopPreviewSkinGo;

	public PlayerHomeAnimationController unlockSkinTroopPreviewAnimation;

	public bool HomeActive => false;

	protected override void Awake()
	{
	}

	public void HideUI()
	{
	}

	public void ShowUI()
	{
	}

	public void DisableInteractive()
	{
	}

	public void EnableInteractive()
	{
	}

	public void DeactiveJoytick()
	{
	}

	public void ActiveJoytick()
	{
	}

	public void ShowGlobalResources(bool anim = false, bool updateImmediately = true)
	{
	}

	public void RefreshGlobalResource()
	{
	}

	private void RefreshGlobalAdsTicket()
	{
	}

	public void RefreshGlobalCoinAnim()
	{
	}

	public void RefreshGlobalElixirAnim()
	{
	}

	public void RefreshGlobalAdsTicketAnim()
	{
	}

	public void HideGlobalResource()
	{
	}

	public void FadeOut(Action fadeOutDone, bool immediately)
	{
	}

	public void FadeIn(Action fadeInDone, float duration = 1f)
	{
	}

	public void ShowHome()
	{
	}

	public void ShowWinLose(bool isWin)
	{
	}

	[Button(null)]
	public void ShowLevelBuff()
	{
	}

	[Button(null)]
	public void ShowTalent()
	{
	}

	[Button(null)]
	public void ShowRevive()
	{
	}

	public void ShowPause()
	{
	}

	public void ShowDelayContinueGame(UnityAction onContinue)
	{
	}

	public void ShowLoseTroopWarning()
	{
	}

	public void ShowSetting()
	{
	}

	public void ShowUIPopupChangeLanguage()
	{
	}

	[Button(null)]
	public void ShowBonusGate()
	{
	}

	public void ShowStarterPack()
	{
	}

	public void ShowNoAdsPack()
	{
	}

	public void ShowIAPPackAtHome()
	{
	}

	public void ShowShop()
	{
	}

	public void ShowShop(int scrollID)
	{
	}

	public void ShowPopupInAppReview()
	{
	}

	[Button(null)]
	public void ShowSkin()
	{
	}

	[Button(null)]
	public void ShowSkinUnlockProgress()
	{
	}

	public void ShowSkinUnlockCongratulation(bool isUnlockFromSkinPopup)
	{
	}

	[Button(null)]
	public void RotateUnlockSkin()
	{
	}
}
