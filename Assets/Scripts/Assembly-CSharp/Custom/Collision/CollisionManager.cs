using System;
using System.Collections.Generic;
using Everest.CustomEditor;
using HiGame;
using Unity.Collections;
using UnityEngine;

public class CollisionManager : Singleton<CollisionManager>, ICanCollisionManager
{
	private const int MAX_OBJECTS = 1000;

	private static NativeArray<CollisionData> _bulletDatas;

	private static Dictionary<int, ICanCollision> _bulletReferences;

	private static Dictionary<int, int> _bulletIndexMap;

	private static NativeArray<int> _activeBulletIndices;

	private static int _activeBulletCount;

	private static int _firstEmptyBulletSlot;

	private static NativeArray<CollisionData> _unitDatas;

	private static Dictionary<int, ICanCollision> _unitReferences;

	private static Dictionary<int, int> _unitIndexMap;

	private static NativeArray<int> _activeUnitIndices;

	private static int _activeUnitCount;

	private static int _firstEmptyUnitSlot;

	private static NativeArray<CollisionData> _obstacleDatas;

	private static Dictionary<int, ICanCollision> _obstacleReferences;

	private static Dictionary<int, int> _obstacleIndexMap;

	private static NativeArray<int> _activeObstacleIndices;

	private static int _activeObstacleCount;

	private static int _firstEmptyObstacleSlot;

	private NativeArray<bool> collisionBulletUnitResults;

	private NativeArray<bool> collisionBulletObstacleResults;

	private NativeArray<bool> collisionUnitObstacleResults;

	private NativeArray<int> collidingBulletUnitIndices;

	private NativeArray<int> collidingBulletObstacleIndices;

	private NativeArray<int> collidingUnitObstacleIndices;

	private static NativeArray<OverlapCheckData> _overlapChecks;

	private static NativeArray<int> _activeOverlapIndices;

	private static int _activeOverlapCount;

	private static Dictionary<int, Action<List<ICanCollision>>> _overlapCallbacks;

	private const int MAX_OVERLAPS = 100;

	private NativeList<int> _overlapResults;

	[SerializeField]
	private TestCollisionObject testCollisionObjectPrefab;

	[SerializeField]
	private TestCollisionObject testCollisionObjectMovePrefab;

	[SerializeField]
	private BaseBullet testBulletPrefab;

	[SerializeField]
	private DamageInfo testDamageInfo;

	[SerializeField]
	private bool debugTxt;

	[SerializeField]
	private bool debugCollider;

	protected override void Awake()
	{
	}

	public void RegisterCollisionObject(ICanCollision obj)
	{
	}

	private static void RegisterToArray(CollisionData data, int id, ICanCollision obj, NativeArray<CollisionData> dataArray, Dictionary<int, ICanCollision> references, Dictionary<int, int> indexMap, NativeArray<int> activeIndices, ref int activeCount, ref int firstEmptySlot)
	{
	}

	public void UnregisterCollisionObject(ICanCollision obj)
	{
	}

	private static void UnregisterFromArray(int id, NativeArray<CollisionData> dataArray, Dictionary<int, ICanCollision> references, Dictionary<int, int> indexMap, ref int firstEmptySlot, ref int activeCount, NativeArray<int> activeIndices)
	{
	}

	private static int FindFirstEmptySlot(int startFrom, NativeArray<CollisionData> dataArray)
	{
		return 0;
	}

	private void InitializeResultArrays(int length)
	{
	}

	private void InitializeArrayIfNeeded(ref NativeArray<CollisionData> array, int length)
	{
	}

	private void InitializeArrayIfNeeded(ref NativeArray<bool> array, int length)
	{
	}

	private void InitializeArrayIfNeeded(ref NativeArray<int> array, int length)
	{
	}

	private void DisposeArrayIfCreated<T>(ref NativeArray<T> array) where T : struct
	{
	}

	[Button(null)]
	private void SpawnCollisionObjects()
	{
	}

	[Button(null)]
	private void FireBullet()
	{
	}

	[Button(null)]
	private void FireBullet2()
	{
	}

	private void UpdateCollisionDataPositions()
	{
	}

	private void Update()
	{
	}

	private static void CheckCollisions(NativeArray<CollisionData> dataA, NativeArray<CollisionData> dataB, int countA, int countB, NativeArray<bool> results, NativeArray<int> indices, Dictionary<int, ICanCollision> referencesA, Dictionary<int, ICanCollision> referencesB, NativeArray<int> activeIndicesA, NativeArray<int> activeIndicesB)
	{
	}

	public void RequestOverlapCheck(Vector3 position, float radius, LayerMask layers, Action<List<ICanCollision>> callback)
	{
	}

	public void RequestBoxOverlapCheck(Vector3 position, Vector3 size, Quaternion rotation, LayerMask layers, Action<List<ICanCollision>> callback)
	{
	}

	private void AddOverlapCheck(OverlapCheckData data, Action<List<ICanCollision>> callback)
	{
	}

	private void ProcessOverlapChecks()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void DrawCollisionData(NativeArray<CollisionData> dataArray, NativeArray<int> activeIndices, int activeCount, Color color)
	{
	}

	private void OnDestroy()
	{
	}
}
