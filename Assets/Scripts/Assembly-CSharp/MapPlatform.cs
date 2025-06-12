using UnityEngine;

public class MapPlatform : MonoBehaviour, ICanCollision
{
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

	public void UnregisterCollision()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
