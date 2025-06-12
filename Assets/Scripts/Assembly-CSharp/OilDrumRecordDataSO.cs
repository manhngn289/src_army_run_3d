using System.Collections.Generic;
using UnityEngine;

public class OilDrumRecordDataSO : ObjectRecordDataSO
{
	public float maxHp;

	public DrumType drumType;

	public DrumMode drumMode;

	public int troopInUtility;

	public float speed;

	public float distanceCheckPlayer;

	public List<int> hpPerBarrelTemps;

	public override void Record(MonoBehaviour objectRecord, ObjectRecordableDataType objectRecordableDataType)
	{
	}
}
