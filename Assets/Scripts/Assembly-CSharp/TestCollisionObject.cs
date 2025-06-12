using UnityEngine;

public class TestCollisionObject : MonoBehaviour, ICanCollision
{
	[SerializeField]
	private float limitTime;

	[SerializeField]
	private CollisionSetting collisionSetting;

	private float currentTime;

	private bool isCollision;

	[SerializeField]
	private bool autoMove;

	[SerializeField]
	private bool deactivateOnCollision;

	[SerializeField]
	private bool limitByTime;

	public ColliderShape Shape => default(ColliderShape);

	public ICanCollisionManager CollisionManager { get; set; }

	public ColliderType ColliderType => default(ColliderType);

	public MonoBehaviour SelfBehaviour => null;

	public LayerMask SelfLayer => default(LayerMask);

	public LayerMask CollisionLayer => default(LayerMask);

	public Vector3 Position => default(Vector3);

	public Quaternion Rotation => default(Quaternion);

	public Vector3 CenterOffset => default(Vector3);

	public float SphereRadius => 0f;

	public Vector3 BoxSize => default(Vector3);

	public bool IsActionOnNotCollision => false;

	public void UnregisterCollision()
	{
	}

	public void OnNotCollision()
	{
	}

	private void Update()
	{
	}

	private void Deactivate()
	{
	}

	public void OnCollision()
	{
	}

	public void OnCollision(ICanCollision objectCollisionWith)
	{
	}

	public void NotCollision()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
