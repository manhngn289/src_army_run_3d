using UnityEngine;

public abstract class BaseLevelBuffSO : ScriptableObject
{
	public int buffID;

	public int rarity;

	public abstract void ActiveBuff();
}
