using UnityEngine;

[CreateAssetMenu(fileName = "SkipItPackShopSetting", menuName = "ScriptableObjects/Shop/SkipItPackShopSetting")]
public class SkipItPackShopSetting : ScriptableObject
{
	public IAPProductId skipItPackType;

	public Sprite packSprite;

	public int rewardQuantity;

	public float defaultPrice;
}
