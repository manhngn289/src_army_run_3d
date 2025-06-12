using DG.Tweening;
using TMPro;
using UnityEngine;

public class PopupRevive : PopupSingleton<PopupRevive>
{
	[SerializeField]
	private TMP_Text countdownTxt;

	[SerializeField]
	private float delayContinueTime;

	[SerializeField]
	private float scaleUp;

	[SerializeField]
	private float scaleUpTime;

	[SerializeField]
	private float fadeTime;

	[SerializeField]
	private Ease easeUp;

	[SerializeField]
	private Ease easeFade;

	protected override void LoadData()
	{
	}

	private void OnEnable()
	{
	}

	private void CountdownTimer()
	{
	}

	public void ReviveBtnClick()
	{
	}

	private void Revive()
	{
	}

	public void NoThanks()
	{
	}
}
