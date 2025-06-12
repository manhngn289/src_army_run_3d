using UnityEngine;

[CreateAssetMenu(fileName = "BaseUnitAttackStatSO", menuName = "ScriptableObjects/BaseUnitAttackStatSO")]
public class BaseUnitAttackStatSO : ScriptableObject
{
	public float range;

	public float attackSpeed;

	public float attack;

	public float critRate;

	public float critDamage;

	public float chaseTargetRange;

	public float chaseTargetRangeInPath;
}
