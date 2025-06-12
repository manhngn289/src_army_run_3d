using System;
using UnityEngine;

namespace Aluta.Ragdoll
{
	[Serializable]
	public class RagdollBoxCollider
	{
		public Vector3 center;

		public Vector3 size;

		public RagdollBoxCollider(BoxCollider capsuleCollider)
		{
		}
	}
}
