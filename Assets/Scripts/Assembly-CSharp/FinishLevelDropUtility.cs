using Aluta;
using UnityEngine;

public class FinishLevelDropUtility : MonoBehaviour
{
	public enum OtherUtilityCanSpawnType
	{
		Gatling = 0,
		Shield = 1
	}

	private const int LIMIT_ENABLE_SPAWN_TROOP_UTILITY = 15;

	[SerializeField]
	[ReadOnly]
	private UtilityCanSpawned getTroopUtilitySpawned;

	[SerializeField]
	[ReadOnly]
	private UtilityCanSpawned otherUtilitySpawned;

	[SerializeField]
	private OtherUtilityCanSpawnType utilityCanSpawnType;

	[SerializeField]
	private UtilityCanSpawned getTroopUtility;

	[SerializeField]
	private UtilityCanSpawned[] otherUtilityCanSpawns;

	[SerializeField]
	private float timeSpawnTroopUtility;

	[SerializeField]
	private float timeSpawnOtherUtility;

	[SerializeField]
	private Transform[] randomSpawnPoint;

	[SerializeField]
	[ReadOnly]
	private float currentSpawnTroopUtilityTime;

	[SerializeField]
	[ReadOnly]
	private float currentSpawnOtherUtility;

	public bool startSpawnUtility;

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void CheckSpawnGetTroopUtility()
	{
	}

	private void CheckSpawnOtherUtility()
	{
	}

	private UtilityCanSpawned SpawnUtility(UtilityCanSpawned utilitySpawn)
	{
		return null;
	}

	private UtilityCanSpawned SpawnUtility(OtherUtilityCanSpawnType typeSpawn)
	{
		return null;
	}
}
