using Aluta;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class UtilityGTOilDrumTemp : MonoBehaviour
{
	[SerializeField]
	[ReadOnly]
	private UtilityGTOilDrum rootOilDrum;

	[SerializeField]
	private TMP_Text currentHpTxt;

	[SerializeField]
	[ReadOnly]
	private float currentHp;

	[SerializeField]
	private Transform shakeObject;

	[SerializeField]
	private Animator animator;

	private Tween shakeObjTween;

	private Tween hpTxtTween;

	private Coroutine animTakeDmg;

	[SerializeField]
	protected float shakeObjectValue;

	[SerializeField]
	protected float scaleTxtValue;

	[SerializeField]
	private OilDrumTempCheckGround oilDrumTempCheckGround;

	private void TakeDmgAnim()
	{
	}

	public void SetData(UtilityGTOilDrum root, float value)
	{
	}

	public void SetActiveGravity()
	{
	}

	public void DecreaseHp()
	{
	}

	public void PlayAnimBarrel(bool isForward)
	{
	}
}
