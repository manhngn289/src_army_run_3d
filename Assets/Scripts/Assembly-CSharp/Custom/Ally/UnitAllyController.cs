using System;
using Everest.CustomEditor;
using UnityEngine;

public class UnitAllyController : UnitController, ICanBurned, ICanCollision
{
	public Action<UnitAllyController> AllyDead;

	public ParticleSystem spawnFx;

	public TroopPoint spawnPoint;

	private PlayerManager playerManager;

	[SerializeField]
	private bool notInHole;

	[SerializeField]
	private UnitCheckGround groundChecker;

	[SerializeField]
	private ParticleSystem survivorFx;

	[SerializeField]
	private float checkItemDropRadius;

	[SerializeField]
	private UnitAllyCollectDropItem unitAllyCollectDropItem;

	[SerializeField]
	private float jumpForce;

	[SerializeField]
	private CollisionSetting collisionSetting;

	[DisplayAsString]
	public bool CanChangePos => false;

	[DisplayAsString]
	public override bool CanAttack => false;

	public UnitHealth UnitHealth => null;

	public override bool Jumping { get; set; }

	public float CheckItemDropRadius => 0f;

	public override UnitState CurrentMoveState
	{
		get
		{
			return default(UnitState);
		}
		set
		{
		}
	}

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

	protected void Update()
	{
	}

	public void ChangeCheckItemDropRadius()
	{
	}

	public override void Dead()
	{
	}

	public void UseSpawnFX()
	{
	}

	public override void Init(bool useSoundAndAnim = true)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void ApplyLevelBuff()
	{
	}

	private void CheckStartMove()
	{
	}

	public void RunNoWeapon()
	{
	}

	public void RunNoWeaponToRunNormal()
	{
	}

	private void Jump(float jumpForceApplied)
	{
	}

	private void OnJump()
	{
	}

	public void Survivor()
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

	protected void OnDrawGizmosSelected()
	{
	}

	private void OnValidate()
	{
	}
}
