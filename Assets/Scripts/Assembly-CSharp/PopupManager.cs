using System;
using System.Collections.Generic;
using Aluta;
using UnityEngine;

public class PopupManager<T> : Singleton<T> where T : MonoBehaviour
{
	public Transform[] transPopup;

	public Transform transNotify;

	private Dictionary<Type, MonoBehaviour> popupDic;

	public virtual void ShowPopup<PopupType>(PopupSingleton<PopupType> popup, Transform parent, Transform bgParent = null) where PopupType : MonoBehaviour
	{
	}

	public virtual void DestroyPopup<PopupType>(PopupSingleton<PopupType> popup) where PopupType : MonoBehaviour
	{
	}

	private void GetPopupInParent<PopupType>(PopupSingleton<PopupType> popup, Transform parent) where PopupType : MonoBehaviour
	{
	}
}
