using UnityEngine;

public class UnitAutoDespawn : MonoBehaviour
{
	[SerializeField]
	private Transform unitParent;

	private PlayerManager playerManager;

	[SerializeField]
	private bool checkDeSpawn;

	private void OnEnable()
	{
	}

	private void OnBecameInvisible()
	{
	}

	private void Update()
	{
	}
}
