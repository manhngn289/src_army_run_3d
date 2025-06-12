using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "WeaponDroneDataSO", menuName = "ScriptableObjects/PlayerWeapon/WeaponDroneDataSO")]
public class WeaponDroneDataSO : WeaponDataSO
{
	public float attackRange;

	public int[] droneQuantity;

	public float[] fireRatePerLevel;

	[FormerlySerializedAs("atkMultiplier")]
	public float[] dmgMultiplier;
}
