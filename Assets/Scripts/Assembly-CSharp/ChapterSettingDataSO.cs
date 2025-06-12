using UnityEngine;

[CreateAssetMenu(fileName = "ChapterSettingData", menuName = "ScriptableObjects/ChapterSettingData")]
public class ChapterSettingDataSO : ScriptableObject
{
	[Header("ROAD")]
	public ModuleController moduleControllerPrefab;

	public ModuleModel[] startModulePrefabs;

	public LevelModulesSO chapterModules;

	[Header("FINISH")]
	public FinishLevel finishLevelPrefab;

	public LevelModulesSO firstFinishModules;

	public LevelModulesSO otherFinishModules;

	public ModuleController bossFinishModules;

	public LevelModulesSO bossFinishFirstModule;

	[Header("DECOR")]
	public GameObject decorGoPrefabs;

	public Material skyBoxMaterials;

	public Material decorFarMaterials;

	[Header("OTHER")]
	public TutorialInLevelGO tutorialInLevelGoPrefab;
}
