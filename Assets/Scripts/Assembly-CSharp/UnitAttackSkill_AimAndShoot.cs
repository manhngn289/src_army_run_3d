using UnityEngine;

public class UnitAttackSkill_AimAndShoot : UnitAttackSkill
{
	[SerializeField]
	private float aimDuration;

	[SerializeField]
	private float lockTargetDuration;

	[SerializeField]
	private ParticleSystem aimFx;

	private Coroutine fireBulletCor;

	public override void RefreshSkill()
	{
	}

	public override void UseSkill()
	{
	}

	private void AnimAndShoot()
	{
	}

	public void SkillDone()
	{
	}
}
