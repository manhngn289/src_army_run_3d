using Aluta;
using DG.Tweening;
using TMPro;
using UnityEngine;

public abstract class UtilityDestroyable : MonoBehaviour, ICanTakeDmg, IChangeCamBattle, IActivePlayerAttack, ICanCollision
{
	public float maxHP;

	[ReadOnly]
	[SerializeField]
	protected float currentHp;

	[SerializeField]
	protected TMP_Text currentHPTxt;

	[SerializeField]
	protected Transform pointAttacked;

	private Vector3 initPosShakeObject;

	[SerializeField]
	private Transform shakeObject;

	private Tween shakeObjTween;

	private Tween hpTxtTween;

	private Coroutine animTakeDmg;

	[SerializeField]
	protected float shakeObjectValue;

	[SerializeField]
	protected float scaleTxtValue;

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

	private void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected void Start()
	{
	}

	protected virtual void Init()
	{
	}

	public virtual void TakeDmg(DamageInfo damageInfo, KillAllyType killAllyType)
	{
	}

	public void TakeDmgAnim()
	{
	}

	protected virtual void OnUtilityDestroyed()
	{
	}

	private void OnDisable()
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
