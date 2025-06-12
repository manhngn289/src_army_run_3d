using System.Collections.Generic;
using Aluta;
using Cinemachine;
using UnityEngine;

public class UnitAttackSkill_JumpAttack : UnitAttackSkill
{
	[SerializeField]
	private CinemachineImpulseSource impulseSource;

	[SerializeField]
	private float jumpSpeed;

	[SerializeField]
	private float dropSpeed;

	[SerializeField]
	private float prepareJumpTime;

	[SerializeField]
	private float prepareJumpOnAir;

	[SerializeField]
	private float jumpHeight;

	[SerializeField]
	private float jumpPower;

	[ReadOnly]
	[SerializeField]
	private bool prepareSkillDone;

	[ReadOnly]
	[SerializeField]
	private float currentJumpOnAirTime;

	[SerializeField]
	private Vector3 targetPos;

	[SerializeField]
	private Vector3 targetPosAir;

	[SerializeField]
	private bool onAirDone;

	[SerializeField]
	private GameObject warningGOPrefab;

	[ReadOnly]
	[SerializeField]
	private Transform warningGO1;

	[ReadOnly]
	[SerializeField]
	private Transform warningScaleGO2;

	private bool isConfirmTargetPos;

	[SerializeField]
	private ParticleSystem jumpUpFX;

	[SerializeField]
	private ParticleSystem jumpDownFX;

	private bool isDealDmg;

	[SerializeField]
	private float dmgRadius;

	[SerializeField]
	private ParticleSystem dealDmgFX;

	public override void RefreshSkill()
	{
	}

	public override void UseSkill()
	{
	}

	public void SkillDone()
	{
	}

	private void DealDmgAllTargetInRadius()
	{
	}

	private void DealDmgTargetInRadius(List<ICanCollision> targetInRadius)
	{
	}

	public override void PrepareSkillDone()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
