using Aluta;
using UnityEngine;
using UnityEngine.Events;

public abstract class PopupSingleton<T> : Singleton<T> where T : MonoBehaviour
{
	public GameObject popup;

	public UnityAction onShow;

	public UnityAction onHide;

	protected int initSiblingIndex;

	public PopupAnimation popupAnimation;

	public virtual void ShowPopup(Transform bgParent = null)
	{
	}

	public virtual void HidePopup()
	{
	}

	public void DelayHidePopup()
	{
	}

	protected abstract void LoadData();
}
