using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeTroopDataSO", menuName = "ScriptableObjects/TroopUpgrade/UpgradeTroopDataSO")]
public class UpgradeTroopPriceDataSO : ScriptableObject
{
	public List<int> priceUpgradePreLevel;

	public List<int> evolePrice;
}
