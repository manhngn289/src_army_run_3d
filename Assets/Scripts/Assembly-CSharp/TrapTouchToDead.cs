using UnityEngine;

public class TrapTouchToDead : MonoBehaviour, ICanCollision
{
	public bool isKillAll;

	[SerializeField]
	private AttackerType attackerType;

	[SerializeField]
	private bool initManual;

	[SerializeField]
	private CollisionSetting collisionSetting;

	[SerializeField]
	private KillAllyType killAllyType;

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

	private void OnDisable()
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

	public void UnregisterCollision()
	{
	}

	protected virtual void OnDrawGizmosSelected()
	{
	}
}
