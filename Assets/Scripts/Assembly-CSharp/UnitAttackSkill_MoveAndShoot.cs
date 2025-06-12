using UnityEngine;

public class UnitAttackSkill_MoveAndShoot : UnitAttackSkill
{
	[SerializeField]
	private float delayPerShoot;

	[SerializeField]
	private int fireAmount;

	private Coroutine fireBulletCor;

	public override void RefreshSkill()
	{
	}

	public override void UseSkill()
	{
	}

	private void FireSequenceBullet()
	{
	}
}
