using UnityEngine;

public interface IUnitController
{
	UnitStatInfo StatInfo { get; }

	UnitHealth Health { get; }

	bool IsDead { get; }

	UnitState CurrentMoveState { get; set; }

	UnitAnimationController AnimationController { get; }

	UnitState PreviousMoveState { get; set; }

	bool Jumping { get; set; }

	bool CanAttack { get; }

	Transform LimitTR { get; }

	Vector3 LimitSize { get; }

	void Dead();

	void CachePreviousState();

	void BackToPreviousState();
}
