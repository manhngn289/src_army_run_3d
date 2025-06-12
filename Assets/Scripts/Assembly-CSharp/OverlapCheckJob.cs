using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
public struct OverlapCheckJob : IJob
{
	[ReadOnly]
	public NativeArray<OverlapCheckData> OverlapChecks;

	[ReadOnly]
	public NativeArray<CollisionData> Units;

	[ReadOnly]
	public NativeArray<CollisionData> Obstacles;

	[ReadOnly]
	public NativeArray<int> ActiveOverlapIndices;

	[ReadOnly]
	public NativeArray<int> ActiveUnitIndices;

	[ReadOnly]
	public NativeArray<int> ActiveObstacleIndices;

	public int OverlapCount;

	public int UnitCount;

	public int ObstacleCount;

	public NativeList<int> Results;

	public void Execute()
	{
	}

	private void CheckObjects(OverlapCheckData check, NativeArray<CollisionData> objects, NativeArray<int> activeIndices, int count)
	{
	}

	private bool CheckSphereSphere(float3 posA, float radiusA, float3 posB, float radiusB)
	{
		return false;
	}

	private bool IsOverlapping(OverlapCheckData check, CollisionData obj)
	{
		return false;
	}

	private static bool CheckSphereBox(float3 spherePos, float sphereRadius, CollisionData box)
	{
		return false;
	}
}
