using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FinishLevelRecordData
{
	public FinishType finishType;

	public bool spawnEnemyWithBoss;

	public List<string> randomModuleRecordDatas;

	public ModuleControllerRecordData bossFinishModuleRecordData;

	public GameObject bossPrefab;

	public Vector2 leftRightIntroCamDistance;

	public void Record(FinishLevel finishLevel)
	{
	}
}
