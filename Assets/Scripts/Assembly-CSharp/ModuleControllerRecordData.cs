using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class ModuleControllerRecordData
{
	public string moduleName;

	public string moduleID;

	public ModuleModelRecordData moduleModelRecordData;

	public List<EnemySpawnPointRecordData> spawnPointDatas;

	public Vector3 trapDefaultPosition;

	public Vector3 utilityDefaultPosition;

	public Vector3 spawnPointDefaultPosition;

	public Vector3 gateDefaultPosition;

	public bool hasGate;

	[FormerlySerializedAs("GateRecordData")]
	public QuadGateRecordData gateRecordData;

	private List<IObjectCanRecord> trapRecords;

	public List<ObjectRecordDataSO> trapRecordDatasObjectSO;

	private List<IObjectCanRecord> utilityRecords;

	public List<ObjectRecordDataSO> utilityRecordDatasObjectSO;

	public void RecordData(ModuleController moduleControllerRecord, string path)
	{
	}

	public void RecordData(ModuleController moduleControllerRecord)
	{
	}
}
