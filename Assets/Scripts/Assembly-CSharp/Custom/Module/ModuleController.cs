using System.Collections.Generic;
using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class ModuleController : MonoBehaviour
{
	[ReadOnly]
	public int runTimeIndex;

	public ModuleModel moduleModel;

	[SerializeField]
	private string moduleModelID;

	public Transform moduleModelPos;

	public Transform gatePointDefault;

	public Transform spawnPointDefault;

	public Transform utilityPointDefault;

	public Transform trapPointDefault;

	public QuadGates gatePrefab;

	public EnemySpawnPoint spawnPointPrefab;

	public QuadGates gateInModule;

	public List<EnemySpawnPoint> enemySpawnPoint;

	[SerializeField]
	private bool autoGetESP;

	[SerializeField]
	private ModuleControllerRecordData moduleControllerModelRecordData;

	private List<IObjectCanRecord> trapRecords;

	private List<IObjectCanRecord> utilityRecords;

	public int TotalEnemy => 0;

	public ModuleModel ModuleModel => null;

	public string ModuleModelID => null;

	public void UpdateModuleID()
	{
	}

	[Button(null)]
	public void CreateSpawnPoint()
	{
	}

	public void CreateSpawnPoint(EnemySpawnPoint spawnPointTemplate)
	{
	}

	[Button(null)]
	public void CreateGate()
	{
	}

	public void DeleteGate()
	{
	}

	public void DeleteSpawnPoint(int idDelete = -1)
	{
	}

	private void OnEnable()
	{
	}

	public void GetAllSpawnPoint()
	{
	}

	public void GetGate()
	{
	}

	public void SetEnemyConditionToSpawnPoint(UnitEnemyController enemyCondition)
	{
	}

	public ModuleControllerRecordData ModuleControllerRecordData(string path)
	{
		return null;
	}

	public ModuleControllerRecordData ModuleControllerRecordData()
	{
		return null;
	}

	public void ResetModule()
	{
	}

	public void RecoverFromData(ModuleControllerRecordData data)
	{
	}
}
