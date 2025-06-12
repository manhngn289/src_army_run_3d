using TMPro;
using UnityEngine;

public class Gate : MonoBehaviour, ICanCollision
{
	private readonly string[] GATE_TYPE_STRING;

	[SerializeField]
	private GateValue gateValue;

	[SerializeField]
	private DoubleGate group;

	[SerializeField]
	private TMP_Text valueTxt;

	[SerializeField]
	private GameObject[] gatePerType;

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

	public void SetGateData(GateValue gateValue, DoubleGate gateGroup = null)
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void UpdateGateFollowType()
	{
	}

	public void DisableGate(bool deactive = false)
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

	private void OnDrawGizmos()
	{
	}

	private void OnDisable()
	{
	}
}
