using UnityEngine;

public class PierceBullet : SimpleBullet
{
	public int pierceAmount;

	private int countEnemyDealDmg;

	public override void SetData(DamageInfo damageInfo)
	{
	}

	public override void OnHitTarget(ICanTakeDmg targetHealth, Vector3 hitPoint)
	{
	}
}
