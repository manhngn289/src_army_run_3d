using Everest.CustomEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class TrapSpiningSpikeLog : TrapCheckPlayer, IObjectCanRecord
{
	public SpiningSpikeType type;

	public float rotateTime;

	public bool clockwise;

	[FormerlySerializedAs("roatateSpikeLogTime")]
	[SerializeField]
	private float rotateSpikeLogTime;

	[SerializeField]
	private Transform rotatePartTR1;

	[SerializeField]
	private Transform rotatePartSpikeTR1;

	[SerializeField]
	private Transform rotatePartTR2;

	[SerializeField]
	private Transform rotatePartSpikeTR2;

	[SerializeField]
	private TrapSpiningSpikeLogRecordDataSO trapSpinningSpikeLogRecordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	private Vector3 Rotation => default(Vector3);

	protected override void OnPlayerInRadius()
	{
	}

	[Button(null)]
	private void UpdateType()
	{
	}

	private void Rotate()
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
