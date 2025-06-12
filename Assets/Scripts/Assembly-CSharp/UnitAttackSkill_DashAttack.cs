using UnityEngine;

public class UnitAttackSkill_DashAttack : UnitAttackSkill
{
	[SerializeField]
	private float dashSpeed;

	[SerializeField]
	private float prepareTime;

	[SerializeField]
	private float dashTime;

	[SerializeField]
	private float currentDashTime;

	[SerializeField]
	private TrapTouchToDead touchToDeadTrap;

	[SerializeField]
	private ParticleSystem warningPrefab;

	[SerializeField]
	private ParticleSystem[] dashFX;

	private Coroutine dashCoroutine;

	private void OnSpawned()
	{
	}

	public override void RefreshSkill()
	{
	}

	public override void UseSkill()
	{
	}

	private void AimAndDash()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
