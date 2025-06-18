using UnityEngine;

public class WeaponJumpToPlayer : MonoBehaviour
{
	[SerializeField]
	private PlayerWeaponType weaponType;

	[SerializeField]
	private bool startMove;

	[SerializeField]
	private GameObject[] weapons;

	public float flightDuration;

	public float peakY;

	private Vector3 startPosition;

	private float elapsedTime;

	private bool isReachPlayer;

	private Transform targetMove;

	public void SetData(PlayerWeaponType playerWeaponType)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
