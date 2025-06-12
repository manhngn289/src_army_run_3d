using System.Collections.Generic;
using UnityEngine;

public class ObjectAlongPathRecordDataSO : ObjectRecordDataSO
{
	public GameObject objectAlongPath;

	public int amount;

	public int offsetFromRoot;

	public List<Vector3> WayPoints;

	public override void Record(MonoBehaviour objectRecord, ObjectRecordableDataType objectRecordableDataType)
	{
	}

	public void Record(ObjectAlongPathRecordDataSO objectAlongPathRecordData)
	{
	}
}
