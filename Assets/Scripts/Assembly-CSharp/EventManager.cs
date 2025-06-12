using System;
using System.Collections.Generic;
using UnityEngine.Events;

public static class EventManager
{
	private static readonly Dictionary<NormalEventName, List<NormalEventInvoker>> normalInvokers;

	private static readonly Dictionary<NormalEventName, List<UnityAction>> normalListeners;

	private static readonly Dictionary<StringEventName, List<StringEventInvoker>> stringInvokers;

	private static readonly Dictionary<StringEventName, List<UnityAction<string>>> stringListeners;

	private static readonly Dictionary<GeneralEventName, List<GeneralEventInvoker>> generalInvokers;

	private static readonly Dictionary<GeneralEventName, List<Delegate>> generalListeners;

	private static bool isInitial;

	public static bool IsInitial => false;

	public static void Initialize()
	{
	}

	public static void AddInvoker(NormalEventName eventName, NormalEventInvoker invoker)
	{
	}

	public static void AddListener(NormalEventName eventName, UnityAction listener)
	{
	}

	public static void RemoveInvoker(NormalEventName eventName, NormalEventInvoker invoker)
	{
	}

	public static void RemoveInvoker(GeneralEventName eventName, GeneralEventInvoker invoker)
	{
	}

	public static void RemoveListener(NormalEventName eventName, UnityAction listener)
	{
	}

	public static void AddInvoker(StringEventName eventName, StringEventInvoker invoker)
	{
	}

	public static void AddListener(StringEventName eventName, UnityAction<string> listener)
	{
	}

	public static void RemoveInvoker(StringEventName eventName, StringEventInvoker invoker)
	{
	}

	public static void RemoveListener(StringEventName eventName, UnityAction<string> listener)
	{
	}

	public static void AddInvoker(GeneralEventName eventName, GeneralEventInvoker invoker)
	{
	}

	public static void AddListener<T>(GeneralEventName eventName, UnityAction<T> listener)
	{
	}

	public static void AddListener<T, U>(GeneralEventName eventName, UnityAction<T, U> listener)
	{
	}

	public static void AddListener<T, U, V>(GeneralEventName eventName, UnityAction<T, U, V> listener)
	{
	}

	public static void RemoveListener<T>(GeneralEventName eventName, UnityAction<T> listener)
	{
	}

	public static void RemoveListener<T, U>(GeneralEventName eventName, UnityAction<T, U> listener)
	{
	}

	public static void RemoveListener<T, U, V>(GeneralEventName eventName, UnityAction<T, U, V> listener)
	{
	}

	public static void BroadcastEvent(NormalEventName eventName)
	{
	}

	public static void BroadcastEvent(StringEventName eventName, string str)
	{
	}

	public static void BroadcastEvent<T>(GeneralEventName eventName, T t)
	{
	}

	public static void BroadcastEvent<T, U>(GeneralEventName eventName, T t, U u)
	{
	}

	public static void BroadcastEvent<T, U, V>(GeneralEventName eventName, T t, U u, V v)
	{
	}
}
