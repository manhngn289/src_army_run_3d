using Aluta;
using UnityEngine;

public class UtilityCanSpawned : MonoBehaviour
{
	[SerializeField]
	[ReadOnly]
	private bool isActive;

	[SerializeField]
	[ReadOnly]
	private GameObject child;

	public bool IsActive => false;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnSpawned()
	{
	}
}
