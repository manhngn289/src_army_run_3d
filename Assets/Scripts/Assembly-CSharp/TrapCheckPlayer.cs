using Aluta;
using UnityEngine;

public class TrapCheckPlayer : MonoBehaviour
{
	public const float PLAYER_CHECK_DEFAULT_RADIUS = 40f;

	public float checkTroopRadius;

	[SerializeField]
	protected bool isAutoDeActive;

	[ReadOnly]
	public bool isActivePlayerRadius;

	private PlayerManager playerManager;

	private Coroutine autoDisableCoroutine;

	private void OnEnable()
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void OnPlayerInRadius()
	{
	}

	private void AutoDisable()
	{
	}

	protected virtual void OnPlayerPassing()
	{
	}

	protected virtual void OnDrawGizmosSelected()
	{
	}
}
