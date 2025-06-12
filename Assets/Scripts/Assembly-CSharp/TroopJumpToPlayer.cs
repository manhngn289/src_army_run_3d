using UnityEngine;

public class TroopJumpToPlayer : MonoBehaviour
{
	[SerializeField]
	private bool startMove;

	public float flightDuration;

	public float peakY;

	private Vector3 startPosition;

	private float elapsedTime;

	private bool isReachPlayer;

	private Transform targetMove;

	private int troopTake;

	public void SetData(int troopTake)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
