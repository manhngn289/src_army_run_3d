using System.Collections.Generic;
using UnityEngine;

public class IceGrenade : Grenade
{
	[SerializeField]
	private float freezeDuration;

	public override Vector3 DetectTargetPos()
	{
		return default(Vector3);
	}

	public override void DealDmgAllTargetInRadius()
	{
	}

	private void FreezeAllTarget(List<ICanCollision> targetInRadius)
	{
	}
}
