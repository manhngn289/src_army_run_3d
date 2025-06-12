using UnityEngine;

[CreateAssetMenu(fileName = "CollisionSetting", menuName = "ScriptableObjects/Others/CollisionSetting")]
public class CollisionSetting : ScriptableObject
{
	public ColliderType colliderType;

	public ColliderShape colliderShape;

	public LayerMask selfLayer;

	public LayerMask targetLayer;

	public Vector3 centerOffset;

	public float sphereRadius;

	public Vector3 boxSize;

	public bool isActionOnNotCollision;

	public bool canOverrideSettingLayer;
}
