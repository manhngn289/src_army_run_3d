using Aluta.Ragdoll;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Quy/RagdollExportData")]
public class RagdollExportData : ScriptableObject
{
	public RagdollBoxPartData root;

	public RagdollBoxPartData spine;

	public RagdollSpherePartData head;

	public RagdollCapsulePartData hipL;

	public RagdollCapsulePartData kneeL;

	public RagdollBoxPartData ankleL;

	public RagdollCapsulePartData hipR;

	public RagdollCapsulePartData kneeR;

	public RagdollBoxPartData ankleR;

	public RagdollCapsulePartData shoulderL;

	public RagdollCapsulePartData elbowL;

	public RagdollBoxPartData wristL;

	public RagdollCapsulePartData shoulderR;

	public RagdollCapsulePartData elbowR;

	public RagdollBoxPartData wristR;
}
