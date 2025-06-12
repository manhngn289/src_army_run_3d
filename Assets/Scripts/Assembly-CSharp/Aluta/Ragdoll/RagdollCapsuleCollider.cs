using System;
using UnityEngine;

namespace Aluta.Ragdoll
{
	[Serializable]
	public class RagdollCapsuleCollider
	{
		public Vector3 center;

		public float radius;

		public float height;

		public int direction;

		public RagdollCapsuleCollider(CapsuleCollider capsuleCollider)
		{
		}
	}
}
