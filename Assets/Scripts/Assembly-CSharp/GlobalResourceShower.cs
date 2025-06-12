using System;
using TMPro;
using UnityEngine;

public class GlobalResourceShower : MonoBehaviour
{
	[SerializeField]
	private GlobalResourceType resourceType;

	[SerializeField]
	private TMP_Text resourceTxt;

	public void RefreshGlobalResource()
	{
	}

	public void RefreshGlobalResourceAnim(Action onComplete)
	{
	}
}
