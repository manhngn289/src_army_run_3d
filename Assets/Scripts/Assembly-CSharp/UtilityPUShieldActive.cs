using Everest.CustomEditor;
using UnityEngine;

public class UtilityPUShieldActive : MonoBehaviour
{
	private const float MIN_RADIUS = 0.7f;

	private const float OFFSET_RADIUS = 0.2f;

	[SerializeField]
	private GameObject shieldPrefab;

	[SerializeField]
	private int shiledAmount;

	[SerializeField]
	private float shieldRadius;

	[SerializeField]
	private Transform rotatePart;

	[SerializeField]
	private bool isTest;

	[SerializeField]
	private float testRadius;

	private float ShieldRadius => 0f;

	private float Angle => 0f;

	private void OnEnable()
	{
	}

	[Button(null)]
	private void Test()
	{
	}

	public void SetRadius(float radius)
	{
	}

	[Button(null)]
	private void AdjustShieldPos()
	{
	}

	private void UpdatePosShield(Transform shield, float angle)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnValidate()
	{
	}
}
