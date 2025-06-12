using System.Collections.Generic;
using Aluta;
using UnityEngine;

public class UtilityPUThorHammerActive : MonoBehaviour, IFindTarget
{
	[SerializeField]
	private Transform rotateHammer;

	[SerializeField]
	private Transform hammer;

	[SerializeField]
	private GameObject[] hammerGlows;

	[ReadOnly]
	[SerializeField]
	private int currentLevel;

	[SerializeField]
	[ReadOnly]
	private bool startAttack;

	[ReadOnly]
	[SerializeField]
	private WeaponThorHammerDataSO data;

	[SerializeField]
	[ReadOnly]
	private float currentAttackDelay;

	[SerializeField]
	private ParticleSystem[] attackFxPreparePerLevel;

	[SerializeField]
	[ReadOnly]
	private Collider[] enemies;

	private Coroutine attackCor;

	[SerializeField]
	private float scaleUp;

	[SerializeField]
	private float scaleDown;

	[SerializeField]
	private float timeScaleUp;

	[SerializeField]
	private float timeScaleDown;

	[SerializeField]
	private UtilityPUTargetSelector targetSelector;

	private float minDistance;

	private int idNearest;

	private float DelayAttack => 0f;

	private float DmgMultiplier => 0f;

	public float DistanceCheck => 0f;

	public void SetLevel(int level, WeaponThorHammerDataSO weaponData = null)
	{
	}

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}

	private void ScaleHammer()
	{
	}

	private void OnDisable()
	{
	}

	private UnitHealth FindTargetToAttack()
	{
		return null;
	}

	private void Attack()
	{
	}

	private void DealDmgInRadius(List<ICanCollision> targets)
	{
	}
}
