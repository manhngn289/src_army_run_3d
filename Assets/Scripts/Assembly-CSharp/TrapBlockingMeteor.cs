using UnityEngine;

public class TrapBlockingMeteor : TrapDestroyable, IObjectCanRecord
{
	[SerializeField]
	private ParticleSystem breakTrapFX;

	public TrapCheckPlayerToImpluse trapCheckPlayerToImpluse;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	public TrapBlockingMeteorRecordDataSO trapBlockingMeteorRecordDataSo;

	protected override void OnTrapDestroyed()
	{
	}

	public IRecordData DataRecord(string path, int index)
	{
		return null;
	}

	public void RecoverFromData(IRecordData objectRecordData)
	{
	}

	public void RecoverFromDataFallback()
	{
	}
}
