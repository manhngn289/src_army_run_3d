using Aluta;
using DG.Tweening;
using Everest.CustomEditor;
using UnityEngine;

public class UtilityPUDroneActive : MonoBehaviour, IFindTarget
{
	[SerializeField]
	private float randomMoveRadius;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float delayNextMove;

	[SerializeField]
	private bool useCurve;

	[SerializeField]
	private AnimationCurve moveCurve;

	[SerializeField]
	[Header("ATTACK")]
	private Transform droneLookAt;

	[SerializeField]
	private Transform[] attackPoints;

	[SerializeField]
	[ReadOnly]
	private int currentLevel;

	public WeaponDroneDataSO data;

	[SerializeField]
	[ReadOnly]
	private bool startAttack;

	[SerializeField]
	private Ease ease;

	[SerializeField]
	private BulletInfo droneBullet;

	[SerializeField]
	[ReadOnly]
	private float currentAttackDelay;

	[SerializeField]
	[ReadOnly]
	private Collider[] enemies;

	private ICanTakeDmg targetHealth;

	[SerializeField]
	private UtilityPUTargetSelector targetSelector;

	private float minDistance;

	private int idNearest;

	[SerializeField]
	private BaseBullet defaultBullet;

	[SerializeField]
	[ReadOnly]
	private BaseBullet currentBullet;

	[SerializeField]
	private ParticleSystem[] fireBulletFX;

	private bool isLeftAttack;

	private float DelayAttack => 0f;

	private float DmgMultiplier => 0f;

	private BaseBullet BulletUse
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private Transform AttackPoint => null;

	public float DistanceCheck => 0f;

	public void SetLevel(int level, WeaponDroneDataSO dataWeapon = null, bool isAnim = true)
	{
	}

	private void Hide(bool isAnim)
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	[Button(null)]
	private void MoveRandomInSphere()
	{
	}

	private void FixedUpdate()
	{
	}

	private void FindTargetToAttack()
	{
	}

	private void LookAtTarget()
	{
	}

	private void GetBullet(Vector3 bulletPos, Quaternion bulletRotation, bool isLeft)
	{
	}

	private void FireBullet()
	{
	}

	private void Attack()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
