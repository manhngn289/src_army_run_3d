using Unity.Mathematics;
using UnityEngine;

public struct OverlapCheckData
{
	public int ID;

	public float3 Position;

	public float Radius;

	public float3 Size;

	public quaternion Rotation;

	public LayerMask Layers;

	public ColliderShape Shape;

	public bool IsActive;
}
