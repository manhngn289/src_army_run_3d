using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
	public EnemyDataSO enemyDataSO;

	public EnemyDataSO enemyEliteDataSO;

	public EnemyMoveType enemyMoveType;

	public EnemyMoveType enemyMoveTypeAfterPath;

	public float checkDistanceRadius;

	public float initTimeDelay;

	public int totalWave;

	public List<SpawnData> spawnDatasList;

	public float spawnRadius;

	[SerializeField]
	private Vector3[] pathMove;

	[SerializeField]
	private Vector3[] wayPoints;

	public bool spawnInfinityWithEnemy;

	public UnitEnemyController enemyCondition;

	public List<bool> foldStates;

	public bool isSpawnDataListFolded;

	[SerializeField]
	private bool isSpawned;

	private Coroutine checkPlayerDistanceCoroutine;

	private Coroutine spawnEnemyOverTime;

	[SerializeField]
	private EnemySpawnPointRecordData recordRecordData;

	public int TotalEnemy => 0;

	public Vector3[] WayPoints => null;

	public EnemySpawnPointRecordData RecordData => null;

	private void InitPathMove()
	{
	}

	private void SpawnEnemy(int spawn, int idEnemy, bool isElite)
	{
	}

	public void UpdateWayPoints(Vector3[] waypointUpdate)
	{
	}

	private void SpawnEnemyWithSetting()
	{
	}

	private void CheckPlayerDistance()
	{
	}

	public void SetEnemyCondition(UnitEnemyController enemyCondition)
	{
	}

	private void SpawnEnemyOverTime()
	{
	}

	public void RecoverFromData(EnemySpawnPointRecordData recordData)
	{
	}
}
