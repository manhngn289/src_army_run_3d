using UnityEngine;
using UnityEngine.Events;

public class TrapSustainOnTime : MonoBehaviour
{
	[SerializeField]
	private float sustainTime;

	[SerializeField]
	private UnityEvent onTrapDisable;

	private void OnEnable()
	{
	}

	public void SustainTrap()
	{
	}
}
