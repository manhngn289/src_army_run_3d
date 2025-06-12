using Aluta;
using UnityEngine;

public class UnitCheckGround : MonoBehaviour, IUnitCheckGround
{
	[SerializeField]
	private UnitController unitController;

	[SerializeField]
	private UnitHealth health;

	[SerializeField]
	private float velocity;

	[SerializeField]
	private float jumpForce;

	[SerializeField]
	private float jumpHeight;

	[SerializeField]
	private float fallThreshold;

	[SerializeField]
	private float fallDeathHeight;

	private bool isGrounded;

	[SerializeField]
	[ReadOnly]
	private bool isInHole;

	[SerializeField]
	[ReadOnly]
	private bool isOnPlatform;

	private const float SCALE_FALL_HOLE = 3f;

	private bool needSoundLanding;

	private bool IsGrounded => false;

	public bool IsInHole
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsOnPlatform
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float PlatformPos
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateGroundMovement()
	{
	}

	private void UpdateUnitState(bool isGround)
	{
	}

	private void HandleGrounded()
	{
	}

	private void HandleJumping()
	{
	}

	private void HandleFalling()
	{
	}

	private void CheckFallDeath()
	{
	}

	public void Jump()
	{
	}
}
