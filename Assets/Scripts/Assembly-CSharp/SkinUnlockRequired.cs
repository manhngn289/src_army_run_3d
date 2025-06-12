using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinUnlockRequired", menuName = "ScriptableObjects/Others/SkinUnlockRequired", order = 1)]
public class SkinUnlockRequired : ScriptableObject
{
	public List<int> skinUnlockRequired;
}
