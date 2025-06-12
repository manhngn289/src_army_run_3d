public class UtilityPUEvolveCharacter : UtilityPUBase
{
	public int levelEvolve;

	protected override void PlayerTakeUtility(PlayerPowerUpManager playerPowerUp)
	{
	}

	public override IRecordData DataRecord(string path, int index)
	{
		return null;
	}

	public override void RecoverFromData(IRecordData objectRecordData)
	{
	}

	public override void RecoverFromDataFallback()
	{
	}
}
