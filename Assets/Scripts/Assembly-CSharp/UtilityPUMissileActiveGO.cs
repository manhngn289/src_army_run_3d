using System.Collections.Generic;
using Aluta;
using Cinemachine;
using Everest.CustomEditor;
using UnityEngine;

public class UtilityPUMissileActiveGO : MonoBehaviour
{
	[SerializeField]
	private bool startMove;

	public float flightDuration;

	public float peakX;

	public float peakY;

	public float peakZ;

	private Vector3 startPosition;

	public float rotateSpeed;

	private float elapsedTime;

	[SerializeField]
	private Vector3 targetMove;

	[SerializeField]
	private ParticleSystem missileHitTargetFX;

	[SerializeField]
	private ParticleSystem missileTrailFX;

	[SerializeField]
	private float dmgRadius;

	[SerializeField]
	private CinemachineImpulseSource impulseSource;

	[SerializeField]
	private float randomPeakX;

	private float randomPeakY;

	[SerializeField]
	private bool useCurve;

	[SerializeField]
	private AnimationCurve heightCurve;

	[SerializeField]
	private AnimationCurve widthCurve;

	[SerializeField]
	[ReadOnly]
	private bool isDealDmg;

	private void Start()
	{
	}

	private void OnSpawned()
	{
	}

	private void OnDespawned()
	{
	}

	private void Update()
	{
	}

	private void DealAoeDmg()
	{
	}

	private static void DealDmgAllTarget(List<ICanCollision> targets)
	{
	}

	public void StartMove(Vector3 targetMove, Vector3 startPos)
	{
	}

	[Button(null)]
	private void ResetMissile()
	{
	}
}
