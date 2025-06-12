using UnityEngine;

[CreateAssetMenu(fileName = "ItemDropSetting", menuName = "ScriptableObjects/Others/ItemDropSetting")]
public class ItemDropSetting : ScriptableObject
{
	public bool isJumpWhenSpawn;

	public bool autoCheckPlayer;

	public float radiusJump;

	public float jumpPower;

	public float minRadiusJump;

	public float jumpDuration;

	public float speedMoveTarget;

	public float maxSpeedRotate;

	public AnimationCurve jumpCurve;

	public ParticleSystem takeFX;
}
