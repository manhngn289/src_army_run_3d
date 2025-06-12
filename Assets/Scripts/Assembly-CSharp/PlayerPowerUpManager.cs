using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aluta;
using Everest.CustomEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerPowerUpManager : MonoBehaviour
{
	private const int PLAYER_WEAPON_MAX_LEVEL = 3;

	[SerializeField]
	private PlayerManager playerManager;

	[FormerlySerializedAs("utilityPUPos")]
	[SerializeField]
	private Transform utilityPuPos;

	public PlayerWeaponType currentWeaponActive;

	public int activeWeaponLevel;

	public PlayerWeaponDataSO playerWeaponDataSo;

	[SerializeField]
	private ParticleSystem takeWeaponFx;

	[SerializeField]
	private UtilityPUThorHammerActive utilityPUThorHammerActivePrefab;

	[ReadOnly]
	public UtilityPUThorHammerActive thorHammerActiveGo;

	[SerializeField]
	private UtilityPUDroneManager utilityPUDroneManagerPrefab;

	[ReadOnly]
	public UtilityPUDroneManager utilityPuDroneManagerGo;

	[SerializeField]
	private UtilityPUShieldActive utilityPUShieldActivePrefab;

	[DisplayAsString]
	private UtilityPUShieldActive utilityPuShieldActiveGo;

	[SerializeField]
	private ParticleSystem healFX;

	[SerializeField]
	private TroopEvolveStatDataSO troopEvolveStatDataSo;

	[SerializeField]
	private UtilityPUMissilesActive utilityPUMissilesActivePrefab;

	[DisplayAsString]
	private UtilityPUMissilesActive utilityPuMissilesActiveGo;

	[SerializeField]
	private float activeMissileTime;

	[SerializeField]
	[ReadOnly]
	private List<bool> activeSkillCanUse;

	[Header("TEST")]
	[SerializeField]
	private PlayerWeaponType weaponTest;

	private WeaponFireBulletDataSO CurrentWeaponFireBullet => null;

	private BaseBullet CurrentBulletChange => null;

	private float FireRateChange => 0f;

	public List<bool> ActiveSkillCanUse => null;

	[Button(null)]
	public void ResetPlayerWeapon()
	{
	}

	[Button(null)]
	public void TestWeapon()
	{
	}

	public void ActivePlayerWeapon(PlayerWeaponType weaponType, bool autoIncreaseLevel = true)
	{
	}

	private void ChangeBulletAndAttackSpeed()
	{
	}

	private void ChangeAllTroopAttackSpeed(float value, bool isBuff, bool isSetValue)
	{
	}

	private void ChangeAllTroopBullet(BaseBullet bulletChange)
	{
	}

	public void ActiveWeaponToTroop(UnitAllyController troopActiveWeapon)
	{
	}

	private void ActiveThorHammer()
	{
	}

	private void ActiveDrone()
	{
	}

	public void ActiveShield(float duration)
	{
	}

	[IteratorStateMachine(typeof(_003CDeActiveUtility_003Ed__29))]
	private static IEnumerator DeActiveUtility(GameObject utilityGo, float duration)
	{
		return null;
	}

	private void ActiveTroopShotgun()
	{
	}

	[Button(null)]
	public void HealAllTroop()
	{
	}

	public void ApplyEvolveBuff(int levelEvolve)
	{
	}

	public void IncreaseActiveSkill(ActiveSkillType activeSkillType)
	{
	}

	public void ActiveMissile(bool isFree, bool isForceActive)
	{
	}

	private void ActiveMissile(float duration)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
