using DG.Tweening;
using Everest.CustomEditor;
using TMPro;
using UnityEngine;

public class PopupDelayContinueGame : PopupSingleton<PopupDelayContinueGame>
{
	[SerializeField]
	private float delayContinueTime;

	[SerializeField]
	private TMP_Text countdownTxt;

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

	[Button(null)]
	private void CountdownContinueGame()
	{
	}
}
