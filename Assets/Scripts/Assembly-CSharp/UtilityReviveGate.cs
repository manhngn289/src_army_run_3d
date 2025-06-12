using Aluta;
using UnityEngine;

public class UtilityReviveGate : MonoBehaviour, IObjectCanRecord, ICanCollision
{
	[ReadOnly]
	public int moduleCacheIndex;

	[SerializeField]
	private UtilityReviveGateRecordDataSO reviveUtilityRecordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	[SerializeField]
	private CollisionSetting collisionSetting;

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

	public void OnNotCollision()
	{
	}

	public void OnCollision(ICanCollision objectCollisionWith)
	{
	}

	public void UnregisterCollision()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDrawGizmos()
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
