using UnityEngine;

public class TrapSlidingPikeLog : TrapCheckPlayer, IObjectCanRecord
{
	public float timeMove;

	public bool leftStart;

	[SerializeField]
	private Transform movePartTR;

	[SerializeField]
	private Transform spikeLogRotate;

	[SerializeField]
	private float spikeLogRotateTime;

	[SerializeField]
	private TrapSlidingSpikeLogRecordDataSO spikeLogRecordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	private float PosEnd => 0f;

	private void OnValidate()
	{
	}

	protected override void OnPlayerInRadius()
	{
	}

	protected override void OnPlayerPassing()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
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
