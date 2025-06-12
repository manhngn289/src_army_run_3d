using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AllyTroopDataSO", menuName = "ScriptableObjects/AllyTroopDataSO")]
public class AllyTroopDataSO : ScriptableObject
{
	public List<UnitAllyController> allAllies;
}
