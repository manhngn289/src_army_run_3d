using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public abstract class UnitAttackSkill : MonoBehaviour
{
	protected const string PREPARE_SKILL_ANIM = "PrepareSkill";

	protected const string USE_SKILL_ANIM = "UseSkill";

	protected readonly int PrepareSkillAnim;

	protected readonly int Skill;

	[SerializeField]
	[ReadOnly]
	protected float limitXFree;

	[SerializeField]
	[ReadOnly]
	protected float limitZFreeBehind;

	[SerializeField]
	[ReadOnly]
	protected float limitZFreeFront;

	[ReadOnly]
	[SerializeField]
	private bool isUsingSkill;

	[SerializeField]
	[ReadOnly]
	private float currentCooldown;

	[SerializeField]
	protected UnitAttack unitAttack;

	[SerializeField]
	private float cooldown;

	protected Animator SelfAnimator => null;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual void Update()
	{
	}

	public void SetLimit(Transform limitPosTr, Vector3 limitSize)
	{
	}

	public virtual void OnUseSkillDone()
	{
	}

	public virtual void PrepareSkillDone()
	{
	}

	public abstract void RefreshSkill();

	[Button(null)]
	protected void RequestUseSkill()
	{
	}

	public abstract void UseSkill();
}
