using UnityEngine;

[CreateAssetMenu(fileName = "MapToolSettingChapter", menuName = "ScriptableObjects/MapToolSettingChapter")]
public class MapToolSettingChapter : ScriptableObject
{
	[Header("ROAD")]
	public ModuleController moduleControllerPrefab;

	public ModuleModel[] startModulePrefabs;

	public GameAllTrapSO gameAllTrapSO;

	public GameAllUtilitySO gameAllUtilitySO;

	public LevelModulesSO chapterModules;

	[Header("FINISH")]
	public FinishLevel finishLevelPrefab;

	public LevelModulesSO firstFinishModules;

	public LevelModulesSO otherFinishModules;

	public ModuleController bossFinishModules;

	public LevelModulesSO bossFinishFirstModule;
}
