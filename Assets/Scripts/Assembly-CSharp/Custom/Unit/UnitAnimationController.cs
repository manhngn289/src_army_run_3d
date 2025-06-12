using Aluta;
using DG.Tweening;
using Everest.CustomEditor;
using FSG.MeshAnimator;
using UnityEngine;

public class UnitAnimationController : MonoBehaviour
{
	private static readonly int AttackSpeed;

	private static readonly int Attack1;

	private static readonly int Run1;

	private static readonly int Jump1;

	private static readonly int NoWeapon;

	private static readonly int Speed;

	private static readonly int SpeedBuff;

	private static readonly int Taunt1;

	private static readonly int Dead1;

	private const string FLASH_NAME = "_FlashIntensity1";

	private const string FREEZE_NAME = "_IceIntensity";

	private const float SPEED_RUN_ANIM_DEFAULT = 2f;

	private const string RUN = "Run";

	private const string RUN_SPEED = "RunSpeed";

	private const string RUN_BUFF = "RunBuff";

	private const string JUMP = "Jump";

	private const string ATTACK = "Attack";

	private const string DEAD = "Dead";

	private const string ATTACK_SPEED = "AttackSpeed";

	private const string RUN_NO_WEAPON = "NoWeapon";

	private const string TAUNT = "Taunt";

	public Animator animator;

	[SerializeField]
	private Vector3 initScale;

	[SerializeField]
	private UnitAttack attack;

	[SerializeField]
	private ParticleSystem deadFX;

	[SerializeField]
	private float currentMoveSpeed;

	[SerializeField]
	private bool hasJump;

	[SerializeField]
	private SkinnedMeshRenderer[] moduleLODRenders;

	[SerializeField]
	private MeshRenderer[] moduleMeshRenderers;

	[SerializeField]
	private bool useMeshAnimator;

	[SerializeField]
	private MeshAnimatorBase meshAnimator;

	[SerializeField]
	private bool hasBuffSpeed;

	public float defaultSpeed;

	[ReadOnly]
	[SerializeField]
	private bool isRun;

	[ReadOnly]
	[SerializeField]
	private bool isAttack;

	[ReadOnly]
	[SerializeField]
	private bool isJump;

	[ReadOnly]
	public bool enableRunNoWeapon;

	[ReadOnly]
	public bool isRunNoWeapon;

	[SerializeField]
	private bool useRunNoWeapon;

	[SerializeField]
	private bool isRandomRun;

	[SerializeField]
	private bool constanceRunAnim;

	private bool isInitRandom;

	[SerializeField]
	private MeshAnimationBase idleAnimation;

	[SerializeField]
	private MeshAnimationBase runAnimation;

	[SerializeField]
	private MeshAnimationBase stayAttackAnimation;

	[SerializeField]
	private MeshAnimationBase runAttackAnimation;

	private Tweener takeDmgEffect;

	private Vector3 scaleTakeDmg;

	[SerializeField]
	private bool scaleWhenTakeDmg;

	[SerializeField]
	private float brightValue;

	[SerializeField]
	private bool usePoolDeadFX;

	private MaterialPropertyBlock mpb;

	[SerializeField]
	private float freezeValue;

	[SerializeField]
	private bool canFreeze;

	[Header("RAGDOLL")]
	[Space(5f)]
	public bool useRagdoll;

	[SerializeField]
	public bool mixDeadFx;

	[SerializeField]
	private Transform ragdollUnit;

	public float CurrentMoveSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float RunSpeed => 0f;

	private float RunBuff => 0f;

	private float UnitAttackSpeed => 0f;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	public void OnAttack()
	{
	}

	public void OnAttackDone()
	{
	}

	public void OnSkillDone(string condition)
	{
	}

	public void OnPrepareSkillDone()
	{
	}

	[Button(null)]
	public void Idle()
	{
	}

	[Button(null)]
	public void Jump()
	{
	}

	[Button(null)]
	public void Run()
	{
	}

	private void ChangeSpeedMove()
	{
	}

	[Button(null)]
	public void Attack()
	{
	}

	private void SetMeshAnimPlay(bool runStage, bool attackStage)
	{
	}

	private void SetAllLODMatValue(string valueName, float value)
	{
	}

	[Button(null)]
	public void TakeDmgEffect()
	{
	}

	[Button(null)]
	public void Freeze()
	{
	}

	[Button(null)]
	public void ClearFreeze()
	{
	}

	[Button(null)]
	public void Taunt()
	{
	}

	public void DisableTaunt()
	{
	}

	[Button(null)]
	public void Dead()
	{
	}

	private void EnableRagdoll()
	{
	}

	private void OnDisable()
	{
	}

	[Button(null)]
	public void ClearAnim()
	{
	}
}
