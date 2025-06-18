using Unity.Mathematics;
using UnityEngine;

public struct CollisionData
{
	public int ID;

	public ColliderType ColliderType;

	public LayerMask SelfLayer;

	public LayerMask CollisionLayer;

	public ColliderShape Shape;
	
	public float3 Size;

	public float Radius;

	public float3 Position;

	public quaternion Rotation;

	public float3 CenterOffset;

	public bool IsActive;

	public bool IsActionOnNotCollision;
}
