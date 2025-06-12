using UnityEngine;
using UnityEngine.Events;

public class TrapCheckPlayerToDoSomething : TrapCheckPlayer
{
	[SerializeField]
	private UnityEvent onPlayerInRadius;

	protected override void OnPlayerInRadius()
	{
	}
}
