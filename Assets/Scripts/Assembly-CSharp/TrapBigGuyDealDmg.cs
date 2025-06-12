using Cinemachine;
using UnityEngine;

public class TrapBigGuyDealDmg : MonoBehaviour
{
	public TrapBigGuy trapBigGuy;

	[SerializeField]
	private CinemachineImpulseSource impulseSourceTaunt;

	[SerializeField]
	private CinemachineImpulseSource impulseSourceTauntTemp;

	[SerializeField]
	private CinemachineImpulseSource impulseSourceWalk;

	[SerializeField]
	private ParticleSystem tauntFx;

	public void DealDmg()
	{
	}

	public void AttackDone()
	{
	}

	public void Taunt()
	{
	}

	public void TauntDone()
	{
	}

	public void OnWalk()
	{
	}

	public void OnTaunt()
	{
	}
}
