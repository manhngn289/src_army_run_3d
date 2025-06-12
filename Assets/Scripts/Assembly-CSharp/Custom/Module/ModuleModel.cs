using System.Collections.Generic;
using Everest.CustomEditor;
using UnityEngine;

public class ModuleModel : MonoBehaviour
{
	public string modelID;

	public string moduleName;

	public string mapTag;

	public GameObject staticMesh;

	public UtilityMMovingPlatform utilityMMovingPlatformDefault;

	public GameObject defaultDecorHole;

	[SerializeField]
	private UtilityMJump[] allUtilityMJumpDefault;

	[SerializeField]
	private List<MeshFilter> allRendererDefault;

	[SerializeField]
	private List<Mesh> allMeshDefault;

	private bool isCacheMesh;

	[Header("Record Data")]
	[SerializeField]
	private ModuleModelRecordData modelRecordData;

	[SerializeField]
	private UtilityMJump utilityMJumpPrefab;

	public UtilityMJump[] AllJumpInModules => null;

	private void OnSpawned()
	{
	}

	private void OnDespawned()
	{
	}

	private void OnValidate()
	{
	}

	[Button(null)]
	public void CombineBatch()
	{
	}

	public ModuleModelRecordData ModuleModelRecordData(string path)
	{
		return null;
	}

	public void RecoverFromData(ModuleModelRecordData dataRecord)
	{
	}
}
