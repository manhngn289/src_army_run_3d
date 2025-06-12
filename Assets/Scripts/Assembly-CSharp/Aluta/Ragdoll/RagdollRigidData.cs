using System;
using UnityEngine;

namespace Aluta.Ragdoll
{
	[Serializable]
	public class RagdollRigidData
	{
		public float mass;

		public float drag;

		public float angularDrag;

		public CollisionDetectionMode collisionDetectionMode;

		public RagdollRigidData(Rigidbody rigidbody)
		{
		}
	}
}
