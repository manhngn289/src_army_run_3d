using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDataSO", menuName = "ScriptableObjects/EnemyDataSO")]
public class EnemyDataSO : ScriptableObject
{
	public List<UnitEnemyController> allEnemies;
}
