using Aluta;
using TMPro;
using UnityEngine;

public class NotiManager : Singleton<NotiManager>
{
	[SerializeField]
	private Transform notiBG;

	[SerializeField]
	private TMP_Text notiTxt;

	[SerializeField]
	private float delayHideNoti;

	private Coroutine delayHideNotiCor;

	private void OnEnable()
	{
	}

	public void ShowNoti(string noti)
	{
	}
}
