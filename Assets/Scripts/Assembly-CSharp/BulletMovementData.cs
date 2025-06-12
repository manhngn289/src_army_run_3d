using System;
using Unity.Mathematics;

public struct BulletMovementData : IEquatable<BulletMovementData>
{
	public int id;

	public int generation;

	public BulletMovementType type;

	public BulletSpeedType speedType;

	public float3 position;

	public float3 direction;

	public float3 initialPosition;

	public float3 targetPosition;

	public float range;

	public bool isDealDmgDone;

	public bool isHitBlockBullet;

	public float3 hitPos;

	public bool isActive;

	public int canDealDmgTimes;

	public float initialSpeed;

	public float distanceTraveled;

	public float speedMultiplierStart;

	public float speedMultiplierMiddle;

	public float speedMiddleTime;

	public float speedMultiplierEnd;

	public float speedEndTime;

	public float elapsedTime;

	public float duration;

	public float jumpHeight;

	public float3 lastPosition;

	public float3 posCheckPosition;

	public bool Equals(BulletMovementData other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
