using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
public struct CollisionDetectionJob : IJobParallelFor
{
	[ReadOnly]
	public NativeArray<CollisionData> ObjectsA;

	[ReadOnly]
	public NativeArray<CollisionData> ObjectsB;

	[ReadOnly]
	public NativeArray<int> ActiveIndicesA;

	[ReadOnly]
	public NativeArray<int> ActiveIndicesB;

	public int ActiveCountA;

	public int ActiveCountB;

	public NativeArray<bool> CollisionResults;

	public NativeArray<int> CollidingObjectIndices;

	public void Execute(int index)
	{
	}

	private static bool CheckCollision(CollisionData a, CollisionData b)
	{
		return false;
	}

	private static bool CheckSphereSphere(CollisionData a, CollisionData b)
	{
		return false;
	}

	public static bool CheckBoxBox(CollisionData a, CollisionData b)
	{
		return false;
	}

	private static bool TestAxis(float3 axis, float3 delta, float3 aSize, float3 bSize, float3 xb, float3 yb, float3 zb)
	{
		return false;
	}

	private static float ProjectBox(float3 axis, float3 size, float3 xb, float3 yb, float3 zb)
	{
		return 0f;
	}

	private static float ProjectBox(float3 axis, float3 size)
	{
		return 0f;
	}

	private static bool CheckSphereBox(CollisionData sphere, CollisionData box)
	{
		return false;
	}
}
