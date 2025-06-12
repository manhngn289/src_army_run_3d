using UnityEngine;

public class JumpUtilityRecordDataSO : ObjectRecordDataSO
{
	public JumpUtilityType jumpUtilityType;

	public float jumpForce;

	public Vector3 singleModelPosition;

	public override void Record(MonoBehaviour objectRecord, ObjectRecordableDataType objectRecordableDataType)
	{
	}
}
