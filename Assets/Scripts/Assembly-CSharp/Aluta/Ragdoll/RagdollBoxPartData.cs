using System;
using UnityEngine;

namespace Aluta.Ragdoll
{
	[Serializable]
	public class RagdollBoxPartData
	{
		public RagdollJointData jointData;

		public RagdollBoxCollider collider;

		public RagdollRigidData rigidData;

		public RagdollBoxPartData(BoxCollider collider, Rigidbody rigidBody, CharacterJoint joint)
		{
		}
	}
}
