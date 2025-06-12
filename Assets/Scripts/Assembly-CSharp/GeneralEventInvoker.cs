using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GeneralEventInvoker : MonoBehaviour
{
	private List<Delegate> actions;

	public void AddListener(Delegate action)
	{
	}

	public void AddListener<T>(UnityAction<T> action)
	{
	}

	public void AddListener<T, U>(UnityAction<T, U> action)
	{
	}

	public void AddListener<T, U, V>(UnityAction<T, U, V> action)
	{
	}

	public void RemoveListener(Delegate action)
	{
	}

	public void RemoveListener<T>(UnityAction<T> action)
	{
	}

	public void RemoveListener<T, U>(UnityAction<T, U> action)
	{
	}

	public void RemoveListener<T, U, V>(UnityAction<T, U, V> action)
	{
	}

	public void CallEvent<T>(T value)
	{
	}

	public void CallEvent<T, U>(T t, U u)
	{
	}

	public void CallEvent<T, U, V>(T t, U u, V v)
	{
	}
}
