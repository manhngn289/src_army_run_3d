using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

[BurstCompile]
public struct BulletMovementJob : IJobParallelFor
{
	public NativeArray<BulletMovementData> bullets;

	public float deltaTime;

	public void Execute(int index)
	{
	}

	private void MoveSimpleBullet(ref BulletMovementData bullet)
	{
	}

	private void MoveGrenade(ref BulletMovementData bullet)
	{
	}

	private static float CalculateBulletSpeed(ref BulletMovementData bullet)
	{
		return 0f;
	}
}
