using System.Collections.Generic;
using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class TrapLightningWall : MonoBehaviour, IObjectCanRecord, ICanCollision
{
	[SerializeField]
	private TrapLightningWallPole[] middlePoles;

	public Transform[] sidePoles;

	[SerializeField]
	[Range(2f, 5.5f)]
	private float distanceBetweenSidePole;

	[SerializeField]
	private LineConnectTwoPoint lightConnectPole;

	[SerializeField]
	private TrapLightningWallPole middlePolePrefab;

	[SerializeField]
	private int poleDestroyedCount;

	[SerializeField]
	private Transform middlePoleParent;

	[SerializeField]
	private TrapLightningWallPole defaultMiddlePole;

	[SerializeField]
	private CollisionSetting collisionSetting;

	[SerializeField]
	private TrapLightningWallPoleRecordDataSO trapLightningWallPoleRecordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	public List<TrapLightningWallPole> MiddlePoles => null;

	private int PoleDestroyedRequired => 0;

	public ColliderType ColliderType => default(ColliderType);

	public ColliderShape Shape => default(ColliderShape);

	public MonoBehaviour SelfBehaviour => null;

	public LayerMask SelfLayer => default(LayerMask);

	public LayerMask CollisionLayer => default(LayerMask);

	public Vector3 Position => default(Vector3);

	public Quaternion Rotation => default(Quaternion);

	public Vector3 CenterOffset => default(Vector3);

	public float SphereRadius => 0f;

	public Vector3 BoxSize => default(Vector3);

	public bool IsActionOnNotCollision => false;

	private void Start()
	{
	}

	public void CheckTurnOffTrap()
	{
	}

	private void TurnOffTrap()
	{
	}

	private void OnValidate()
	{
	}

	[Button(null)]
	private void UpdateLightningWall()
	{
	}

	[Button(null)]
	private void UpdatePole()
	{
	}

	public void OnNotCollision()
	{
	}

	public void OnCollision(ICanCollision objectCollisionWith)
	{
	}

	private void OnDisable()
	{
	}

	public void UnregisterCollision()
	{
	}

	protected virtual void OnDrawGizmosSelected()
	{
	}

	public IRecordData DataRecord(string path, int index)
	{
		return null;
	}

	public void RecoverFromData(IRecordData objectRecordData)
	{
	}

	public void RecoverFromDataFallback()
	{
	}
}
