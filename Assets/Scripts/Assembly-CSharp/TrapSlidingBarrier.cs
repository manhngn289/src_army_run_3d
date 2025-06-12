using UnityEngine;

public class TrapSlidingBarrier : TrapCheckPlayer, IObjectCanRecord
{
	public Transform movePartTR;

	public float timeMove;

	public bool leftStart;

	[Range(2f, 2.5f)]
	public float limit;

	[SerializeField]
	private TrapSlidingBarrierRecordDataSO trapSlidingBarrierRecordData;

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

	private void OnDestroy()
	{
	}

	private void OnDisable()
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
