using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NotificationConfigSO", menuName = "Notification Config/Notification Config SO", order = 1)]
public class NotificationConfigSO : ScriptableObject
{
	public List<PushInfor> pushInfors;
}
