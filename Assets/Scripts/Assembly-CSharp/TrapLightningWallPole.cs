using UnityEngine;

public class TrapLightningWallPole : TrapDestroyable
{
	public TrapLightningWall trapLightningWall;

	[SerializeField]
	private ParticleSystem destroyedTrapFX;

	protected override void OnTrapDestroyed()
	{
	}
}
