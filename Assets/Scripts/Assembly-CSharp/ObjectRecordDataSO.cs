using UnityEngine;

public class ObjectRecordDataSO : ScriptableObject, IRecordData
{
	public ObjectRecordableDataType objectRecordableDataType;

	public string parentName;

	public Vector3 localPos;

	public Quaternion localRotation;

	public bool isActive;

	public virtual void Record(MonoBehaviour objectRecord, ObjectRecordableDataType objectRecordableDataType)
	{
	}
}
