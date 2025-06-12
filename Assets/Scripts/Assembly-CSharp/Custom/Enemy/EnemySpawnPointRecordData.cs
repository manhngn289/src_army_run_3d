using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EnemySpawnPointRecordData
{
	public List<SpawnData> spawnDatas;

	public float spawnRadius;

	public float checkDistanceRadius;

	public float initTimeDelay;

	public EnemyMoveType enemyMoveType;

	public EnemyMoveType enemyMoveTypeAfterPath;

	public Vector3[] wayPoints;

	public bool spawnInfinityWithEnemy;

	public Vector3 localPosition;

	public void Record(EnemySpawnPoint enemySpawnPoint)
	{
	}
}
