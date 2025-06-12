using Everest.CustomEditor;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public abstract class TrapDestroyable : MonoBehaviour, ICanTakeDmg, IChangeCamBattle, IActivePlayerAttack, ICanCollision
{
	public float maxHP;

	[DisplayAsString]
	protected float CurrentHp;

	[SerializeField]
	protected Transform pointAttacked;

	[FormerlySerializedAs("currentHPTxt")]
	[SerializeField]
	protected TMP_Text currentHpTxt;

	[SerializeField]
	protected Transform shakeObject;

	[SerializeField]
	protected float shakeObjectValue;

	[SerializeField]
	protected float scaleTxtValue;

	protected Coroutine animTakeDmg;

	[SerializeField]
	private CollisionSetting collisionSetting;

	public bool IsDead => false;

	public Transform PointAttacked => null;

	public IChangeBattleCamActivePlayerAttackManager Manager { get; set; }

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

	protected virtual void OnEnable()
	{
	}

	protected void Start()
	{
	}

	public virtual void Init()
	{
	}

	public virtual void TakeDmg(DamageInfo damageInfo, KillAllyType killAllyType)
	{
	}

	[Button(null)]
	protected virtual void TakeDmgAnim()
	{
	}

	protected virtual void OnTrapDestroyed()
	{
	}

	protected virtual void OnDisable()
	{
	}

	public void OnObjectDestroyed()
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

	protected virtual void OnDrawGizmosSelected()
	{
	}
}
