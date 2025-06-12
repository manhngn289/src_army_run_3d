using UnityEngine;

public interface ICanTakeDmg
{
	MonoBehaviour SelfBehaviour { get; }

	bool IsDead { get; }

	Transform PointAttacked { get; }

	void TakeDmg(DamageInfo damageInfo, KillAllyType killAllyType);
}
