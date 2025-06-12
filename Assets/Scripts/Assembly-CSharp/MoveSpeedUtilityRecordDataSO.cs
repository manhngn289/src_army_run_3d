using UnityEngine;

public class MoveSpeedUtilityRecordDataSO : ObjectRecordDataSO
{
	public SpeedChangeType speedChangeType;

	public float buffSimpleValue;

	public float changeBuffSimpleTime;

	public float buffInCombatValue;

	public float changeBuffInCombatTime;

	public float buffNoCombatValue;

	public float changeBuffNoCombatTime;

	public override void Record(MonoBehaviour objectRecord, ObjectRecordableDataType objectRecordableDataType)
	{
	}
}
