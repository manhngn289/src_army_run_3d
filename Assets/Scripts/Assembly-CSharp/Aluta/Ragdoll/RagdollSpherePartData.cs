using System;
using UnityEngine;

namespace Aluta.Ragdoll
{
	[Serializable]
	public class RagdollSpherePartData
	{
		public RagdollJointData jointData;

		public RagdollSphereCollider collider;

		public RagdollRigidData rigidData;

		public RagdollSpherePartData(SphereCollider collider, Rigidbody rigidBody, CharacterJoint joint)
		{
		}
	}
}
