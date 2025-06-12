using System.Collections.Generic;
using UnityEngine;

public class BazookaBullet : SimpleBullet
{
	[SerializeField]
	protected float dmgRadius;

	public override void OnHitTarget(ICanTakeDmg targetHealth, Vector3 hitPoint)
	{
	}

	public override void OnHitGround()
	{
	}

	protected virtual void DealDmgAllTargetInRadius()
	{
	}

	private void DealDmgAllTargetInRadius(List<ICanCollision> targetInRadius)
	{
	}
}
