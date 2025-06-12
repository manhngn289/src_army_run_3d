using System.Collections.Generic;
using UnityEngine;

public class CreateObjectWithPath : MonoBehaviour, IObjectCanRecord
{
	public int pathResolution;

	public bool showSettings;

	public bool showPointLabels;

	public bool showHandles;

	public float pointSize;

	public SnapAxis snapAxis;

	public bool updatePointsWithRoot;

	public bool foldWayPoints;

	public int offsetFromRoot;

	public List<Vector3> WayPoints;

	public Vector3[] path;

	public int amount;

	public GameObject objectPrefab;

	public List<Transform> objectsInstantiated;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	public ObjectAlongPathRecordDataSO objectAlongPathRecordDataSO;

	private bool isStartCheckPlayer;

	private bool recoverDataDone;

	private Transform playerManagerTr;

	private PlayerManager playerManager;

	private bool isObjectsInitialized;

	public int DistanceBetweenObject => 0;

	public void UpdateWayPoints(List<Vector3> waypointUpdate)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void CreatePath()
	{
	}

	private void OnValidate()
	{
	}

	public void UpdateObjectAlongPath()
	{
	}

	public void UpdateObjectPos()
	{
	}

	public void ClearObject()
	{
	}

	public IRecordData DataRecord(string path, int index)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	public void RecoverFromData(IRecordData objectRecordData)
	{
	}

	private void Update()
	{
	}

	private void InitObject()
	{
	}

	public void RecoverFromDataFallback()
	{
	}
}
