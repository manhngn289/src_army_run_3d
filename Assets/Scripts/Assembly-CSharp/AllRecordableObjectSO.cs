using Everest;
using UnityEngine;

[CreateAssetMenu(fileName = "AllRecordableObjectSO", menuName = "ScriptableObjects/AllRecordableObjectSO")]
public class AllRecordableObjectSO : ScriptableObject
{
	public EnumResource<ObjectRecordableDataType, GameObject> objectRecordableData;
}
