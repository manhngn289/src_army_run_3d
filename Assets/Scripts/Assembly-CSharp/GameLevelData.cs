using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/GameLevelData", fileName = "GameLevelData")]
public class GameLevelData : ScriptableObject
{
	public List<LevelController> levelPrefabs;
}
