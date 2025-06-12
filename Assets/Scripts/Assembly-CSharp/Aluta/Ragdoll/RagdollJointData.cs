using System;
using UnityEngine;

namespace Aluta.Ragdoll
{
	[Serializable]
	public class RagdollJointData
	{
		public Vector3 axis;

		public Vector3 swingAxis;

		public float lowTwistLimit;

		public float highTwistLimit;

		public float swing1Limit;

		public float swing2Limit;

		public RagdollJointData(CharacterJoint joint)
		{
		}
	}
}
