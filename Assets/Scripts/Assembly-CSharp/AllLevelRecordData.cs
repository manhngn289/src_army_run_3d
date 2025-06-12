using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AllLevelRecordData", menuName = "ScriptableObjects/AllLevelRecordData")]
public class AllLevelRecordData : ScriptableObject
{
	public List<LevelTemplateData> levelRecordDatas;
}
