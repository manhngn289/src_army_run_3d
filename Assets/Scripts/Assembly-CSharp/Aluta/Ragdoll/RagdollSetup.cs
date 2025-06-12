using UnityEngine;

namespace Aluta.Ragdoll
{
	public class RagdollSetup : MonoBehaviour
	{
		[SerializeField]
		private RagdollExportData ragdollDataTemplate;

		[SerializeField]
		private string pathExport;

		[SerializeField]
		private GameObject root;

		[SerializeField]
		private GameObject spine;

		[SerializeField]
		private GameObject head;

		[SerializeField]
		private GameObject[] hipLs;

		[SerializeField]
		private GameObject[] hipRs;

		[SerializeField]
		private GameObject[] armLs;

		[SerializeField]
		private GameObject[] armRs;

		private GameObject hipL;

		private GameObject kneeL;

		private GameObject ankleL;

		private GameObject hipR;

		private GameObject kneeR;

		private GameObject ankleR;

		private GameObject shoulderL;

		private GameObject elbowL;

		private GameObject wristL;

		private GameObject shoulderR;

		private GameObject elbowR;

		private GameObject wristR;

		[SerializeField]
		[ReadOnly]
		[Header("RigidBody")]
		private Rigidbody rootRb;

		[SerializeField]
		[ReadOnly]
		private Rigidbody spineRb;

		[ReadOnly]
		[SerializeField]
		private Rigidbody headRb;

		[ReadOnly]
		[SerializeField]
		private Rigidbody hipLRb;

		[ReadOnly]
		[SerializeField]
		private Rigidbody kneeLRb;

		[ReadOnly]
		[SerializeField]
		private Rigidbody ankleLRb;

		[SerializeField]
		[ReadOnly]
		private Rigidbody hipRRb;

		[ReadOnly]
		[SerializeField]
		private Rigidbody kneeRRb;

		[SerializeField]
		[ReadOnly]
		private Rigidbody ankleRRb;

		[SerializeField]
		[ReadOnly]
		private Rigidbody shoulderLRb;

		[SerializeField]
		[ReadOnly]
		private Rigidbody elbowLRb;

		[SerializeField]
		[ReadOnly]
		private Rigidbody wristLRb;

		[SerializeField]
		[ReadOnly]
		private Rigidbody shoulderRRb;

		[SerializeField]
		[ReadOnly]
		private Rigidbody elbowRRb;

		[SerializeField]
		[ReadOnly]
		private Rigidbody wristRRb;

		[ReadOnly]
		[SerializeField]
		[Header("Joint")]
		private CharacterJoint spineJoint;

		[SerializeField]
		[ReadOnly]
		private CharacterJoint hipLJoint;

		[SerializeField]
		[ReadOnly]
		private CharacterJoint kneeLJoint;

		[ReadOnly]
		[SerializeField]
		private CharacterJoint ankleLJoint;

		[SerializeField]
		[ReadOnly]
		private CharacterJoint hipRJoint;

		[SerializeField]
		[ReadOnly]
		private CharacterJoint kneeRJoint;

		[SerializeField]
		[ReadOnly]
		private CharacterJoint ankleRJoint;

		[SerializeField]
		[ReadOnly]
		private CharacterJoint headJoint;

		[ReadOnly]
		[SerializeField]
		private CharacterJoint shoulderLJoint;

		[ReadOnly]
		[SerializeField]
		private CharacterJoint elbowLJoint;

		[ReadOnly]
		[SerializeField]
		private CharacterJoint wristLJoint;

		[SerializeField]
		[ReadOnly]
		private CharacterJoint shoulderRJoint;

		[SerializeField]
		[ReadOnly]
		private CharacterJoint elbowRJoint;

		[SerializeField]
		[ReadOnly]
		private CharacterJoint wristRJoint;

		[Header("Collider")]
		[SerializeField]
		[ReadOnly]
		private BoxCollider rootCollider;

		[ReadOnly]
		[SerializeField]
		private BoxCollider spineCollider;

		[ReadOnly]
		[SerializeField]
		private SphereCollider headCollider;

		[SerializeField]
		[ReadOnly]
		private CapsuleCollider hipLCollider;

		[ReadOnly]
		[SerializeField]
		private CapsuleCollider kneeLCollider;

		[ReadOnly]
		[SerializeField]
		private BoxCollider ankleLCollider;

		[ReadOnly]
		[SerializeField]
		private CapsuleCollider hipRCollider;

		[SerializeField]
		[ReadOnly]
		private CapsuleCollider kneeRCollider;

		[ReadOnly]
		[SerializeField]
		private BoxCollider ankleRCollider;

		[ReadOnly]
		[SerializeField]
		private CapsuleCollider shoulderLCollider;

		[SerializeField]
		[ReadOnly]
		private CapsuleCollider elbowLCollider;

		[SerializeField]
		[ReadOnly]
		private BoxCollider wristLCollider;

		[SerializeField]
		[ReadOnly]
		private CapsuleCollider shoulderRCollider;

		[ReadOnly]
		[SerializeField]
		private CapsuleCollider elbowRCollider;

		[ReadOnly]
		[SerializeField]
		private BoxCollider wristRCollider;

		[ContextMenu("Setup Default")]
		public void Setup()
		{
		}

		private void OnValidate()
		{
		}

		[ContextMenu("Export Data")]
		public void ExportData()
		{
		}

		[ContextMenu("Apply Data")]
		public void LoadData()
		{
		}
	}
}
