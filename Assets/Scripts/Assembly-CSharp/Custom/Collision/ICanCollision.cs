using UnityEngine;

public interface ICanCollision
{
	ColliderType ColliderType { get; }

	ColliderShape Shape { get; }

	MonoBehaviour SelfBehaviour { get; }

	LayerMask SelfLayer { get; }

	LayerMask CollisionLayer { get; }

	Vector3 Position { get; }

	Quaternion Rotation { get; }

	Vector3 CenterOffset { get; }

	float SphereRadius { get; }

	Vector3 BoxSize { get; }

	bool IsActionOnNotCollision { get; }

	void OnCollision(ICanCollision objectCollisionWith);

	void OnNotCollision();

	void UnregisterCollision();
}
