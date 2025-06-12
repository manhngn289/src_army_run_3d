using System.Collections.Generic;
using Aluta;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

public class TargetSelector : Singleton<TargetSelector>
{
	[BurstCompile]
	private struct FindClosestTargetJob : IJobParallelFor
	{
		[Unity.Collections.ReadOnly]
		public NativeArray<float3> PositionsA;

		[Unity.Collections.ReadOnly]
		public NativeArray<float3> PositionsB;

		[Unity.Collections.ReadOnly]
		public NativeArray<float> RangesA;

		public NativeArray<int> TargetsA;

		public void Execute(int index)
		{
		}
	}

	[BurstCompile]
	private struct TargetRangeCheckJob : IJob
	{
		[Unity.Collections.ReadOnly]
		public NativeArray<float3> EnemyPositions;

		[Unity.Collections.ReadOnly]
		public NativeArray<bool> EnemyAttackAbleStates;

		[Unity.Collections.ReadOnly]
		public float3 PlayerPosition;

		[Unity.Collections.ReadOnly]
		public float DistanceCheck;

		public NativeReference<bool> HasEnemyInRange;

		public void Execute()
		{
		}
	}

	[BurstCompile]
	private struct EnemyAttackActiveJob : IJobParallelFor
	{
		[Unity.Collections.ReadOnly]
		public NativeArray<float3> EnemyPositions;

		[Unity.Collections.ReadOnly]
		public NativeArray<float3> AllyPositions;

		[Unity.Collections.ReadOnly]
		public NativeArray<Quaternion> EnemyRotations;

		[Unity.Collections.ReadOnly]
		public NativeArray<bool> UseRect;

		[Unity.Collections.ReadOnly]
		public NativeArray<float2> EnemyRectCheck;

		[Unity.Collections.ReadOnly]
		public NativeArray<float> EnemyRadiusCheck;

		public NativeArray<bool> HasAllyInRange;

		public void Execute(int index)
		{
		}
	}

	private FindClosestTargetJob findAllyTargetJob;

	private NativeArray<float3> positionsAlly;

	private NativeArray<float> attackRangesAllies;

	private NativeArray<int> targetsOfAllies;

	private FindClosestTargetJob findEnemyTargetJob;

	private NativeArray<float3> positionsEnemy;

	private NativeArray<float> attackRangeEnemies;

	private NativeArray<int> targetsOfEnemies;

	private TargetRangeCheckJob activePlayerAttackJob;

	private TargetRangeCheckJob activePlayerBattleCamJob;

	private NativeArray<bool> enemyAttackAbleStates;

	private NativeReference<bool> activePlayerAttack;

	private NativeReference<bool> changePlayerCam;

	private EnemyAttackActiveJob activeEnemyAttackJob;

	private NativeArray<Quaternion> enemyRotation;

	private NativeArray<bool> useRectCheck;

	private NativeArray<float2> enemyRectCheck;

	private NativeArray<float> enemyRadiusCheck;

	private NativeArray<bool> hasAllyInRange;

	[SerializeField]
	[Aluta.ReadOnly]
	private PlayerManager playerManager;

	[SerializeField]
	[Aluta.ReadOnly]
	private EnemyManager enemyManager;

	[SerializeField]
	[Header("TEST")]
	private bool disable;

	[Aluta.ReadOnly]
	[SerializeField]
	private int previousCountAlly;

	[Aluta.ReadOnly]
	[SerializeField]
	private int previousCountEnemy;

	public bool isStartSelectTarget;

	private List<UnitAllyController> UnitAlly => null;

	private List<UnitEnemyController> UnitEnemy => null;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private static void ReinitializeNativeArray<T>(ref NativeArray<T> array, int newSize) where T : struct
	{
	}

	private void OnDestroy()
	{
	}
}
