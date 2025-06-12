using UnityEngine;

public class UnitAttackMelee : UnitAttack
{
	[SerializeField]
	private MeleeCheckDealDmg checkDealDmg;

	[SerializeField]
	private UnitMeleeWeaponController weaponController;

	private void OnDisable()
	{
	}

	public override void InitData()
	{
	}

	public override void Attack()
	{
	}
}
