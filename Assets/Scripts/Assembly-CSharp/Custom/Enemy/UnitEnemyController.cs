using UnityEngine;

public class UnitEnemyController : UnitController, ICanFreeze, ICanBurned, ICanCollision
{
	public int idInitPool;

	[SerializeField]
	private bool selfInit;

	[SerializeField]
	private UnitCheckGround groundChecker;

	public bool checkPlayerRect;

	public float checkPlayerRadius;

	public Vector2 haflCheckBox;

	public bool startAttack;

	public bool enableAttackManual;

	public bool canAttacked;

	public Transform limitPosTr;

	public Vector3 limitSize;

	private Coroutine freezeCor;

	[SerializeField]
	private bool hasTauntAnim;

	[SerializeField]
	private CollisionSetting collisionSetting;

	public UnitCheckGround GroundChecker => null;

	public override Transform LimitTR => null;

	public override Vector3 LimitSize => default(Vector3);

	public override bool CanAttack => false;

	public override bool Jumping
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UnitHealth UnitHealth => null;

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

	public override void Init(bool useSoundAndAnim = true)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected override void OnDespawned()
	{
	}

	public void SetLimitMovement(Transform limitPos, Vector3 limitSize)
	{
	}

	public void Freeze(float duration)
	{
	}

	public void InitMove(EnemyMoveType moveType, Vector3 difInitPos, Vector3[] path, EnemyMoveType moveAfterPath)
	{
	}

	public void TauntAnim()
	{
	}

	public void DisableTauntAnim()
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
