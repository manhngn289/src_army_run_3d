using Aluta;
using UnityEngine;

public class UnitAttackSkill_FireBulletWithAnim : UnitAttackSkill
{
	[SerializeField]
	[ReadOnly]
	private bool useDone;

	[SerializeField]
	private int fireAmount;

	private bool attacked;

	private Coroutine attackCor;

	public override void RefreshSkill()
	{
	}

	public override void UseSkill()
	{
	}

	private void FireBullet()
	{
	}

	public void FireMultipleBulletRandomTarget()
	{
	}

	public void SkillDone()
	{
	}
}
