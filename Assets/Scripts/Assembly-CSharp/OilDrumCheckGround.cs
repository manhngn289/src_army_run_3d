using Aluta;
using UnityEngine;

public class OilDrumCheckGround : MonoBehaviour, IUnitCheckGround
{
	[SerializeField]
	private UtilityGTOilDrum utilityGtOilDrum;

	[SerializeField]
	protected float velocity;

	[ReadOnly]
	[SerializeField]
	protected bool isGrounded;

	[ReadOnly]
	public bool isInHole;

	[ReadOnly]
	public bool isOnPlatform;

	[SerializeField]
	protected UnitCheckHole checkHole;

	[SerializeField]
	protected UnitCheckPlatform checkPlatform;

	[ReadOnly]
	[SerializeField]
	protected float platformHeight;

	[SerializeField]
	private bool isEnableCheckGround;

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

	protected bool IsGrounded => false;

	public void EnableCheckGround()
	{
	}

	protected virtual void UpdateGroundMovement()
	{
	}

	protected void Update()
	{
	}
}
