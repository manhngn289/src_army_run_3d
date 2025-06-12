using System.Collections.Generic;
using Aluta;
using UnityEngine;

public class Grenade : BaseBullet
{
	protected enum PosMoveType
	{
		LerpBetweenTarget = 0,
		RandomAroundTarget = 1
	}

	[SerializeField]
	protected PosMoveType posMoveType;

	[SerializeField]
	protected float normalizePos;

	[SerializeField]
	protected float randomAround;

	[SerializeField]
	protected float dmgRadius;

	[SerializeField]
	protected bool useWarning;

	[SerializeField]
	protected GameObject warningDmgPrefab;

	[SerializeField]
	[ReadOnly]
	protected Transform warningGo;

	private const float JUMP_HEIGHT = 3f;

	public Vector3 targetPos;

	public virtual Vector3 DetectTargetPos()
	{
		return default(Vector3);
	}

	public override void MoveToTarget()
	{
	}

	public virtual void DealDmgAllTargetInRadius()
	{
	}

	private void DealDmgAllTarget(List<ICanCollision> target)
	{
	}

	protected override void OnDisable()
	{
	}

	private void OnDespawned()
	{
	}

	public override void DespawnBullet(Vector3 hitPos, bool activeDmgFX = true, bool immediately = false)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
