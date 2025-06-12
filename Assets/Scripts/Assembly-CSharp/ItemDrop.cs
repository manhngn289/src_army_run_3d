using Aluta;
using UnityEngine;

public class ItemDrop : MonoBehaviour, ICanCollision
{
	private static readonly int Speed;

	[ReadOnly]
	public UnitAllyController targetAllyController;

	[ReadOnly]
	[SerializeField]
	private bool startMove;

	[SerializeField]
	[ReadOnly]
	private bool collected;

	[SerializeField]
	[ReadOnly]
	private bool canMoveToPlayer;

	[SerializeField]
	private ItemDropType type;

	[SerializeField]
	private ItemDropSetting setting;

	[SerializeField]
	private Animator itemDropAnimator;

	[SerializeField]
	private CollisionSetting collisionSetting;

	[SerializeField]
	[Range(0f, 1f)]
	private float timeNormalize;

	private Coroutine moveCoroutine;

	private bool isAddCollisionManager;

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

	private void OnEnable()
	{
	}

	private void OnSpawned()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDespawned()
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

	private void DropAndMoveToAllyTroop()
	{
	}

	private void RemoveTarget()
	{
	}

	public void SetTarget(UnitAllyController target)
	{
	}

	private void Update()
	{
	}

	private void PlayerGetItem()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
