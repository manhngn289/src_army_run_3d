using UnityEngine;

[CreateAssetMenu(fileName = "UnitDeadRagdollSettingSO", menuName = "ScriptableObjects/UnitDeadRagdollSettingSO")]
public class UnitDeadRagdollSettingSO : ScriptableObject
{
	public float forceUp;

	public float forceForward;

	public float forceHorizontal;

	public float timeRotate;

	public float torque;
}
