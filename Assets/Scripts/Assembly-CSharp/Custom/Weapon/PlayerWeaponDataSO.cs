using Everest;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerWeaponDataSO", menuName = "ScriptableObjects/PlayerWeaponDataSO")]
public class PlayerWeaponDataSO : ScriptableObject
{
	public EnumResource<PlayerWeaponType, WeaponDataSO> weaponDataSos;
}
