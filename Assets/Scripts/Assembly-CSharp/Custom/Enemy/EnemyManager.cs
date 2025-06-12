using System.Collections.Generic;
using HiGame;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager>
{
	public List<UnitEnemyController> allEnemy;

	public EnemiesPrefabDataSO enemyNormal;

	public EnemiesPrefabDataSO enemyElite;

	public Transform enemySpawnParent;

	private List<ObjectPool<UnitEnemyController>> normalEnemiesPool;

	private List<ObjectPool<UnitEnemyController>> eliteEnemiesPool;

	private Coroutine initEnemyCor;

	private static readonly DamageInfo EnemyManagerDmg;

	protected override void Awake()
	{
	}

	private void InitEnemyPool()
	{
	}

	public void InitEnemyStatFollowLevel()
	{
	}

	public UnitEnemyController GetEnemy(GameObject enemyPrefab)
	{
		return null;
	}

	public UnitEnemyController GetEnemy(int index, bool isElite)
	{
		return null;
	}

	public UnitEnemyController GetEnemyInRange(float distanceCheck)
	{
		return null;
	}

	public void KillAllActiveEnemy()
	{
	}

	public void EnemyDead(UnitController unitEnemyController)
	{
	}

	public void DeSpawnedAll()
	{
	}
}
