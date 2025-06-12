using System.Collections.Generic;
using HiGame;
using Unity.Collections;
using UnityEngine;

public class BulletManager : Singleton<BulletManager>
{
	public AllBulletsDataSO bulletsData;

	private List<ObjectPool<BaseBullet>> bulletObjects;

	public Transform bulletParent;

	private static NativeArray<BulletMovementData> _bulletMovementDatas;

	private static Dictionary<int, BaseBullet> _bulletReferences;

	private static int _activeCount;

	private static NativeArray<int> _activeIndices;

	private static Dictionary<int, int> _bulletIndexMap;

	private static int _firstEmptySlot;

	private const int LOG = 35;

	public static bool IsStartUpdateBullet;

	protected override void Awake()
	{
	}

	public void Init()
	{
	}

	public BaseBullet GetBullet(BulletType bulletType, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public static void DespawnBullet(BaseBullet bullet)
	{
	}

	public void DespawnAllBullets()
	{
	}

	public static void AddBulletToJobSystem(BaseBullet bullet, Vector3 pos, Vector3 dir)
	{
	}

	private static int FindFirstEmptySlot(int startFrom = 0)
	{
		return 0;
	}

	private void Update()
	{
	}

	private static void UpdateBulletTransforms()
	{
	}

	public static void UpdateBulletMovementData(BaseBullet bullet, bool isDealDmg, Vector3 hitPos, bool isHitBlock = false)
	{
	}

	private void OnDestroy()
	{
	}
}
