using UnityEngine;

public class TrapKeysAndDoorKeyFireGO : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem openDoorFX;

	[SerializeField]
	private ParticleSystem trailFX;

	private Transform doorPoint;

	private TrapKeysAndDoor door;

	private bool startMove;

	[SerializeField]
	private float speedMove;

	private void OnDespawned()
	{
	}

	public void OpenDoor(Transform doorPointTarget, TrapKeysAndDoor doorNeedKey)
	{
	}

	private void Update()
	{
	}
}
