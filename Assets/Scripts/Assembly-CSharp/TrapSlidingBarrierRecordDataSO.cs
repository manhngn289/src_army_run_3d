using UnityEngine;

public class TrapSlidingBarrierRecordDataSO : ObjectRecordDataSO
{
	public float checkPlayerDistance;

	public float timeMove;

	public bool leftStart;

	public float limit;

	public Quaternion movePartRotation;

	public override void Record(MonoBehaviour objectRecord, ObjectRecordableDataType objectRecordableDataType)
	{
	}
}
