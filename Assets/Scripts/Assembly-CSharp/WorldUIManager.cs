using Everest;
using UnityEngine;

public class WorldUIManager : Singleton<WorldUIManager>
{
	public DamageTxt prefabDamageTxt;

	public HealthBar healthBarAlly;

	public HealthBar healthBarEnemy;

	[SerializeField]
	private Transform parent;

	private static ObjectPool<DamageTxt> _damageTxtPool;

	private static ObjectPool<HealthBar> _healthBarAllyPool;

	private static ObjectPool<HealthBar> _healthBarEnemyPool;

	private static Camera _mainCamera;

	private void Start()
	{
	}

	private void Init()
	{
	}

	public static void GetDamageTxt(DamageInfo damageInfo, UnitHealth unitHealth)
	{
	}

	public static HealthBar GetHealthBar(bool isAlly)
	{
		return null;
	}

	public static void DespawnAllHealthBar()
	{
	}
}
