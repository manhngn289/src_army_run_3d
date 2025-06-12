using UnityEngine;

public class TrapSpiningSpikeLogRecordDataSO : ObjectRecordDataSO
{
	public float checkPlayerDistance;

	public float rotateTime;

	public SpiningSpikeType type;

	public bool clockwise;

	public override void Record(MonoBehaviour objectRecord, ObjectRecordableDataType objectRecordableDataType)
	{
	}
}
