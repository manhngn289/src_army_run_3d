using System;
using System.Collections.Generic;

[Serializable]
public class ModuleModelRecordData
{
	public List<JumpUtilityRecordDataSO> jumpUtilityRecordDatas;

	public bool movingPlatformDefaultActive;

	public void Record(ModuleModel moduleModel, string path)
	{
	}
}
