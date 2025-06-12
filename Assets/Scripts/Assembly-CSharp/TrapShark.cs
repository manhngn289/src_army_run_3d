using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class TrapShark : MonoBehaviour, IObjectCanRecord, ICanCollision
{
	private static readonly Vector3 TrapCenterPos;

	private static readonly Vector3 TrapLeftPos;

	private static readonly Vector3 TrapBehindPos;

	private static readonly Vector3 TrapRightPos;

	private static readonly Vector3 TrapFrontPos;

	private static readonly Vector3 TrapHorizontalSize;

	private static readonly Vector3 TrapVerticalSize;

	private static readonly Vector3 TrapHorizontalCenter;

	private static readonly Vector3 TrapVerticalCenter;

	private static readonly Vector3 TrapRotateLeft;

	private static readonly Vector3 TrapRotateRight;

	public TrapSharkType trapSharkType;

	public SharkType sharkType;

	public Transform trapTr;

	public Transform trapModelGo;

	public float timeDelayDealDmg;

	public bool isJustDecor;

	[SerializeField]
	private Animator trapAnimator;

	[SerializeField]
	private TrapTouchToDead trapTouchToDead;

	[SerializeField]
	private GameObject trapDecorHorizontal;

	[SerializeField]
	private GameObject trapDecorVertical;

	[SerializeField]
	private TrapSharkDecor trapDecorNoAttack;

	[ReadOnly]
	[SerializeField]
	private bool isActiveTrap;

	[SerializeField]
	private CollisionSetting collisionSetting;

	[SerializeField]
	private TrapSharkRecordDataSO trapSharkRecordDataSO;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	private Vector3 TrapModelPos => default(Vector3);

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
	private void DelayDealDmg()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void InitTrap()
	{
	}

	public void ActiveTrapTouchToDead()
	{
	}

	public void DeActiveTrapTouchToDead()
	{
	}

	private void OnValidate()
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

	protected void OnDrawGizmosSelected()
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
