using Cinemachine;
using UnityEngine;

[RequireComponent(typeof(CinemachineImpulseSource))]
public class TrapCheckPlayerToImpluse : TrapCheckPlayer
{
	[SerializeField]
	private CinemachineImpulseSource impulseSource;

	protected override void OnPlayerInRadius()
	{
	}
}
