using UnityEngine;

public class ObjectRecordableData : MonoBehaviour, IObjectCanRecord
{
	[SerializeField]
	private ObjectRecordableDataRecordDataSO recordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

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
