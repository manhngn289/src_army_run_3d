using UnityEngine;

public class FlameTrap : MonoBehaviour, IObjectCanRecord, ICanCollision
{
	public float hpDmgPercent;

	[SerializeField]
	private float offFlameTime;

	[SerializeField]
	private float onFlameTime;

	[SerializeField]
	private ParticleSystem[] flameFx;

	private bool isOn;

	[SerializeField]
	private CollisionSetting collisionSetting;

	[SerializeField]
	private FlameTrapRecordDataSO flameTrapRecordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	public AttackerType AttackerType => default(AttackerType);

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

	private void OnEnable()
	{
	}

	private void OnFlame()
	{
	}

	public void OffFlame()
	{
	}

	public void OnNotCollision()
	{
	}

	private void Start()
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

	public void OnTriggerStay(Collider other)
	{
	}

	protected void OnDrawGizmosSelected()
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
