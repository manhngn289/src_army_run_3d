using Everest;
using UnityEngine;

[CreateAssetMenu(fileName = "AllBulletsDataSO", menuName = "ScriptableObjects/AllBulletsDataSO")]
public class AllBulletsDataSO : ScriptableObject
{
	public EnumResource<BulletType, BaseBullet> bulletPerTypes;
}
