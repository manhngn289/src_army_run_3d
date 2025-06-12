using System;

[Serializable]
public class DamageInfo
{
	public UnitAttack attacker;

	public AttackerType attackerType;

	public float dmg;

	public DamageType attackType;

	public DamageInfo()
	{
	}

	public DamageInfo(float dmg, DamageType attackType, AttackerType attackerType)
	{
	}

	public DamageInfo MultiplyDmg(float dmgMultiplier)
	{
		return null;
	}
}
