using UnityEngine;

public class MaterialChangeOffset : MonoBehaviour
{
	[SerializeField]
	private ChangeType changeType;

	[SerializeField]
	private Renderer selfRederer;

	[SerializeField]
	private string changeMatPropertyName;

	[SerializeField]
	private float changeValueX;

	[SerializeField]
	private float changeValueY;

	[SerializeField]
	private float timeChangeValue;

	private Material selfMat;

	private Vector2 currentOffset;

	private float currentTimeChangeValue;

	private bool isUp;

	private void OnValidate()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
