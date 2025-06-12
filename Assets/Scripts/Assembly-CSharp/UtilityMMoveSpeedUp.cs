using UnityEngine;
using UnityEngine.Serialization;

public class UtilityMMoveSpeedUp : MonoBehaviour, IObjectCanRecord, ICanCollision
{
	public SpeedChangeType speedChangeType;

	[FormerlySerializedAs("buffValue")]
	[FormerlySerializedAs("buffInCombatValue")]
	[Header("SIMPLE")]
	public float buffSimpleValue;

	[FormerlySerializedAs("changeBuffInCombatTime")]
	[FormerlySerializedAs("changeBuffTime")]
	public float changeBuffSimpleTime;

	[Header("COMPLEX")]
	public float buffNoCombatValue;

	public float changeBuffNoCombatTime;

	public float buffInCombatNewValue;

	public float changeBuffInCombatNewTime;

	[SerializeField]
	private CollisionSetting collisionSetting;

	[SerializeField]
	private float showLabelDis;

	[SerializeField]
	private MoveSpeedUtilityRecordDataSO moveSpeedUtilityRecordData;

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

	private void Start()
	{
	}

	private void OnEnable()
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

	private void OnDisable()
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
