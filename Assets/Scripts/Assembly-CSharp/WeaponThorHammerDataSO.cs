using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "WeaponThorHammerDataSO", menuName = "ScriptableObjects/PlayerWeapon/WeaponThorHammerDataSO")]
public class WeaponThorHammerDataSO : WeaponDataSO
{
	public float attackRange;

	public float attackRadius;

	[FormerlySerializedAs("timeDelayAttack")]
	public float[] attackDelay;

	[FormerlySerializedAs("atkMultiplier")]
	public float[] dmgMultiplier;

	public ParticleSystem[] attackFxPreparePerLevel;

	public ParticleSystem[] attackFxPerLevel;
}
