using System;
using UnityEngine;

namespace Aluta.Ragdoll
{
	[Serializable]
	public class RagdollSphereCollider
	{
		public Vector3 center;

		public float radius;

		public RagdollSphereCollider(SphereCollider collider)
		{
		}
	}
}
