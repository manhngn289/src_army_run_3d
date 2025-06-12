using UnityEngine;

public abstract class UtilityPUBase : MonoBehaviour, IObjectCanRecord, ICanCollision
{
	public ObjectRecordableDataType objectRecordableDataType;

	[SerializeField]
	protected ObjectRecordDataSO objectRecordData;

	[SerializeField]
	protected ParticleSystem takeFX;

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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnNotCollision()
	{
	}

	public void OnCollision(ICanCollision objectCollisionWith)
	{
	}

	protected abstract void PlayerTakeUtility(PlayerPowerUpManager playerPowerUp);

	public void UnregisterCollision()
	{
	}

	public virtual IRecordData DataRecord(string path, int index)
	{
		return null;
	}

	public virtual void RecoverFromData(IRecordData objectRecordData)
	{
	}

	public virtual void RecoverFromDataFallback()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
