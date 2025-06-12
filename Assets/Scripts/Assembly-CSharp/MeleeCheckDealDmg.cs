using System.Collections.Generic;
using UnityEngine;

public class MeleeCheckDealDmg : MonoBehaviour
{
	[SerializeField]
	private UnitAttackMelee attackMelee;

	[SerializeField]
	private float checkRadius;

	public bool checkTarget;

	private Collider[] targets;

	private void Start()
	{
	}

	public void DealMeleeDmg()
	{
	}

	private void DealDmg(List<ICanCollision> collisions)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
