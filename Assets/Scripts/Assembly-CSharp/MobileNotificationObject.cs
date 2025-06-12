using System;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class MobileNotificationObject : MonoBehaviour
{
	[SerializeField]
	private string NOTIFICATION_ID;

	[SerializeField]
	private string NOTIFICATION_NAME;

	[SerializeField]
	private string NOTIFICATION_CATEGORY;

	[SerializeField]
	private string THREAD_IDENTIFIER;

	private List<NotificationInfor> infors;

	private string GIFT_READY;

	private string NEW_OFFER;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Init()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	public void TestNotification()
	{
	}

	public void PushListNotification()
	{
	}

	private void PushItem(NotificationInfor infor, int day, int hour)
	{
	}

	public void GenNotification()
	{
	}

	public void SendNotification(NotificationInfor infor, DateTime time)
	{
	}

	public void SendNotification(string message, DateTime time)
	{
	}

	public void SetupCallback()
	{
	}

	public void OnReceiveNotifcation(AndroidNotificationIntentData data)
	{
	}

	private DateTime GetNotificationTime()
	{
		return default(DateTime);
	}

	private DateTime GetTestNotificationTime()
	{
		return default(DateTime);
	}
}
