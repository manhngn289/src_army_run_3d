using System.Collections.Generic;
using Aluta;
using UnityEngine;

public class UtilityPUDroneManager : MonoBehaviour
{
	[SerializeField]
	private UtilityPUDroneActive utilityPUDroneActivePrefab;

	public List<UtilityPUDroneActive> droneActiveGOs;

	[SerializeField]
	[ReadOnly]
	private WeaponDroneDataSO data;

	[ReadOnly]
	[SerializeField]
	private Transform targetFollow;

	[SerializeField]
	[ReadOnly]
	private Vector3 velocity;

	[SerializeField]
	private float smoothTime;

	public void SetLevel(int activeWeaponLevel, WeaponDroneDataSO droneData = null, Transform followTarget = null)
	{
	}

	private void LateUpdate()
	{
	}

	private void ActiveDrone(WeaponDroneDataSO droneData, int activeWeaponLevel)
	{
	}
}
