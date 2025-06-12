using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TroopEvolveStatDataSO", menuName = "ScriptableObjects/TroopEvolveStatDataSO")]
public class TroopEvolveStatDataSO : ScriptableObject
{
	public List<BaseBullet> bulletEvolve;

	public List<float> maxHpBonusPerLevel;

	public List<float> atkSpeedBonusPerLevel;
}
