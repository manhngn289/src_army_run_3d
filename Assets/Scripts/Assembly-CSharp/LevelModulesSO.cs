using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelModulesSO", menuName = "ScriptableObjects/LevelModules")]
public class LevelModulesSO : ScriptableObject
{
	public List<ModuleModel> modules;
}
