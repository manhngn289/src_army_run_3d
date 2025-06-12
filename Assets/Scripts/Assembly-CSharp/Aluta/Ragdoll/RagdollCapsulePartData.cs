using System;
using UnityEngine;

namespace Aluta.Ragdoll
{
	[Serializable]
	public class RagdollCapsulePartData
	{
		public RagdollJointData jointData;

		public RagdollCapsuleCollider collider;

		public RagdollRigidData rigidData;

		public RagdollCapsulePartData(CapsuleCollider collider, Rigidbody rigidBody, CharacterJoint joint)
		{
		}
	}
}
