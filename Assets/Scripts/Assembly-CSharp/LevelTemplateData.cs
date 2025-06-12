using System.Collections.Generic;
using Everest.CustomEditor;
using UnityEngine;

public class LevelTemplateData : ScriptableObject
{
	public int chapterID;

	public bool runCoin;

	public bool hasVip;

	public List<ModuleControllerRecordData> moduleControllerRecords;

	public List<MoveSpeedUtilityRecordDataSO> moveSpeedUtilityRecords;

	public FinishLevelRecordData finishLevelRecordData;

	public bool hasTutorial;

	public TutorialRecordData tutorialRecordData;

	[Button(null)]
	private void ShowData()
	{
	}
}
