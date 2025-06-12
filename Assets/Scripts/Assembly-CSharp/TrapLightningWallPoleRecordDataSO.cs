using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TrapLightningWallPoleRecordDataSO : ObjectRecordDataSO
{
	public List<Vector3> sidePolesPosition;

	public List<Vector3> middlePolesPosition;

	[FormerlySerializedAs("sidePolesHp")]
	public List<float> middlePolesHp;

	public override void Record(MonoBehaviour objectRecord, ObjectRecordableDataType objectRecordableDataType)
	{
	}
}
