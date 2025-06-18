using System;
using UnityEngine;

[Serializable]
public class PlayerCacheStatus
{
	public Vector3 revivePosition;

	public int evolveLevel;

	public int troopCount;

	public int keyTrapDoor;

	public int activeWeaponLevel;

	public PlayerWeaponType currentWeaponActive;

	public float speedForwardBuff;

	public bool isAutoUpdateSpeed;

	public float buffNoCombatValue;

	public float changeBuffNoCombatTime;

	public float buffInCombatValue;

	public float changeBuffInCombatTime;
}
