using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemiesPrefabDataSO", menuName = "ScriptableObjects/EnemiesPrefabDataSO")]
public class EnemiesPrefabDataSO : ScriptableObject
{
	public List<UnitEnemyController> enemies;
}
