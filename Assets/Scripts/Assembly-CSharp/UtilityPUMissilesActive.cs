using UnityEngine;

public class UtilityPUMissilesActive : MonoBehaviour
{
	[SerializeField]
	private UtilityPUMissileActiveGO missilePrefab;

	[SerializeField]
	private float delayPerMissile;

	[SerializeField]
	private float ranRadiusPos;

	[SerializeField]
	private float maxDistanceFromUtility;

	[SerializeField]
	private float minDistanceFromUtility;

	[Header("TEST")]
	[SerializeField]
	[Space(5f)]
	private bool isTestDuration;

	[SerializeField]
	private float testDuration;

	private void OnEnable()
	{
	}

	public void FireMissiles(float duration)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
