using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AllMapToolSettingByChapter", menuName = "ScriptableObjects/AllMapToolSettingByChapter")]
public class AllMapToolSettingByChapter : ScriptableObject
{
	public List<MapToolSettingChapter> allChapterSettings;

	public AllRecordableObjectSO allRecordableObjectSO;

	public TutorialInLevelGO tutorialInLevelGOPrefab;

	public BossChapterIntroSetting bossChapterIntroSetting;

	public EnemyDataSO bossChapter;
}
