using System.Collections.Generic;
using UnityEngine;

public class TrapMine : TrapCheckPlayer, IObjectCanRecord, ICanCollision
{
	public float dmgRadius;

	[SerializeField]
	protected ParticleSystem dealDmgFX;

	[SerializeField]
	private GameObject trapModel;

	[SerializeField]
	private Animator trapAnimator;

	[SerializeField]
	private CollisionSetting collisionSetting;

	[SerializeField]
	private TrapMineRecordDataSO trapMineRecordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

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

	protected override void OnPlayerInRadius()
	{
	}

	private void DealAoeDmg()
	{
	}

	public void OnNotCollision()
	{
	}

	public void OnCollision(ICanCollision objectCollisionWith)
	{
	}

	private void OnOverlapComplete(List<ICanCollision> overlappedObjects)
	{
	}

	private void OnDisable()
	{
	}

	public void UnregisterCollision()
	{
	}

	protected override void OnDrawGizmosSelected()
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
