using UnityEngine;

public class ShotgunBullet : SimpleBullet
{
	public AnimationCurve speedCurve;

	protected override float BulletSpeed(float speedNormalize)
	{
		return 0f;
	}
}
