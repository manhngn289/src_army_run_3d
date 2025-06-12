using UnityEngine;
using UnityEngine.Events;

public class StringEventInvoker : MonoBehaviour
{
	private UnityEvent<string> unityEvent;

	public UnityEvent<string> UnityEvents => null;

	public void AddListener(UnityAction<string> listener)
	{
	}

	public void RemoveListener(UnityAction<string> listener)
	{
	}

	public void CallEvent(string value)
	{
	}
}
