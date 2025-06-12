using System.Collections.Generic;
using UnityEngine;

public class FireGrenade : Grenade
{
	[SerializeField]
	private float burnDuration;

	[SerializeField]
	private float burnInterval;

	[SerializeField]
	private float dmgBurnMulti;

	public override Vector3 DetectTargetPos()
	{
		return default(Vector3);
	}

	public override void DealDmgAllTargetInRadius()
	{
	}

	private void Burn(List<ICanCollision> targetBurn)
	{
	}
}
