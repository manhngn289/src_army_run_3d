using UnityEngine;

public class TrapSharkRecordDataSO : ObjectRecordDataSO
{
	public TrapSharkType trapSharkType;

	public SharkType sharkType;

	public float timeDelayDealDmg;

	public bool isJustDecor;

	public override void Record(MonoBehaviour objectRecord, ObjectRecordableDataType objectRecordableDataType)
	{
	}
}
