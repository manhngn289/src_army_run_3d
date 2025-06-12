using UnityEngine;

public class TrapSlidingSaw : TrapCheckPlayer, IObjectCanRecord
{
	public float timeMove;

	public bool leftStart;

	public Transform rotatePart;

	[SerializeField]
	private Transform movePartTR;

	[SerializeField]
	private TrapSlidingSawRecordDataSO trapSawRecordData;

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
