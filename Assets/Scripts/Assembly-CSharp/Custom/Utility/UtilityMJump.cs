using Everest.CustomEditor;
using UnityEngine;

public class UtilityMJump : MonoBehaviour, IObjectCanRecord, ICanCollision
{
	private static readonly Vector3 AllJumpColliderSize;

	private static readonly Vector3 LeftRightCenterJumpColliderSize;

	private static readonly Vector3 SingleJumpColliderSize;

	private static readonly Vector3 AllJumpColliderCenter;

	private static readonly Vector3 LeftJumpColliderCenter;

	private static readonly Vector3 RightJumpColliderCenter;

	private const float LEFT_RIGHT_LIMIT = 1.23f;

	public JumpUtilityType jumpUtilityType;

	public float jumpForce;

	[SerializeField]
	private GameObject[] jumpModels;

	public GameObject singleModel;

	[SerializeField]
	private CollisionSetting collisionSetting;

	[SerializeField]
	private JumpUtilityRecordDataSO recordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	private Vector3 BoxJumpSize => default(Vector3);

	private Vector3 BoxJumpPivot => default(Vector3);

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

	[Button(null)]
	public void ChangeUtilityType()
	{
	}

	private void Start()
	{
	}

	public void OnNotCollision()
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

	private void OnDrawGizmosSelected()
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
