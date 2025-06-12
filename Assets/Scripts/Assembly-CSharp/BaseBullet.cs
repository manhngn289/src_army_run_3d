using Aluta;
using Everest.CustomEditor;
using UnityEngine;
using UnityEngine.Serialization;

public abstract class BaseBullet : MonoBehaviour, ICanCollision
{
	public BulletType bulletType;

	public int bulletPriority;

	[SerializeField]
	protected bool useDmgMultiplier;

	[SerializeField]
	protected float dmgMultiplier;

	public float bulletSpeed;

	[SerializeField]
	protected ParticleSystem dealDmgFX;

	public BulletInfo bulletInfo;

	public AudioClip dealDmgSound;

	public AudioClip fireBulletSound;

	[FormerlySerializedAs("isDepawnManual")]
	[SerializeField]
	protected bool isDespawnManual;

	[FormerlySerializedAs("fireBulletFXID")]
	public int fireBulletFxId;

	[SerializeField]
	protected bool isInitTargetLayer;

	[SerializeField]
	[ReadOnly]
	protected bool isTouchObject;

	private int currentGeneration;

	private string[] layerTarget;

	[SerializeField]
	protected CollisionSetting collisionSetting;

	public BulletInfo BulletInfo => null;

	private string[] LayerTarget => null;

	public ColliderShape Shape => default(ColliderShape);

	public ColliderType ColliderType => default(ColliderType);

	public LayerMask SelfLayer => default(LayerMask);

	public LayerMask CollisionLayer => default(LayerMask);

	public MonoBehaviour SelfBehaviour => null;

	public Vector3 Position => default(Vector3);

	public Quaternion Rotation => default(Quaternion);

	public Vector3 CenterOffset => default(Vector3);

	public float SphereRadius => 0f;

	public Vector3 BoxSize => default(Vector3);

	public bool IsActionOnNotCollision => false;

	protected virtual float BulletSpeed(float speedNormalize)
	{
		return 0f;
	}

	public int GetGeneration()
	{
		return 0;
	}

	public virtual void SetData(DamageInfo damageInfo)
	{
	}

	[ContextMenu("MoveToTarget")]
	public abstract void MoveToTarget();

	protected void DealDmg(ICanTakeDmg targetHealth)
	{
	}

	[Button(null)]
	public virtual void DespawnBullet(Vector3 hitPos, bool activeDmgFX = true, bool despawnImmediately = false)
	{
	}

	protected void ActiveDealDmgFx(Vector3 pos)
	{
	}

	public virtual void DespawnBulletImmediate(Vector3 posFx)
	{
	}

	public virtual void OnHitTarget(ICanTakeDmg targetHealth, Vector3 hitPoint)
	{
	}

	protected virtual void OnDisable()
	{
	}

	public virtual void OnHitGround()
	{
	}

	public void ApplyPosition(Vector3 pos)
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
