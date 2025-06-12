using UnityEngine;

[CreateAssetMenu(fileName = "WeaponFireBulletDataSO", menuName = "ScriptableObjects/PlayerWeapon/WeaponFireBulletDataSO")]
public class WeaponFireBulletDataSO : WeaponDataSO
{
	public const float SHOTGUN_TOTAL_BULLET_DEGREE = 14f;

	public BaseBullet[] bulletsPerLevel;

	public float[] fireRateChangePerLevel;
}
