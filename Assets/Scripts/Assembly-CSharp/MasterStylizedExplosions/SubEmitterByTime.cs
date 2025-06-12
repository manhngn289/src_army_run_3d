using UnityEngine;

namespace MasterStylizedExplosions
{
	[ExecuteInEditMode]
	public class SubEmitterByTime : MonoBehaviour
	{
		public ParticleSystem Particle;

		public float TriggerInterval;

		private float LastTime;

		public float Timer;

		private void OnWillRenderObject()
		{
		}
	}
}
