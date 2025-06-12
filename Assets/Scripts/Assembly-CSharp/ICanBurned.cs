public interface ICanBurned
{
	const float DMG_SEQUENCE_TIME = 0.25f;

	UnitHealth UnitHealth { get; }

	void Burn(float hpDmgPercent, AttackerType attackerType)
	{
	}

	void BurnOverTime(float dmgOverTime, float duration, float intervalTime, AttackerType attackerType)
	{
	}
}
