using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class UnitRagdoll : MonoBehaviour
{
	private static readonly int GrayIntensity;

	private const string GRAY_NAME = "_GrayIntensity";

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Rigidbody[] ragdollRbs;

	[SerializeField]
	private Rigidbody ragdollRb;

	[SerializeField]
	private UnitDeadRagdollSettingSO ragdollSetting;

	private Coroutine rotateRbCoroutine;

	[ReadOnly]
	[SerializeField]
	private float timeRotateCurrent;

	[ReadOnly]
	[SerializeField]
	private bool enableTorque;

	[SerializeField]
	[ReadOnly]
	private bool enablingTorque;

	[SerializeField]
	[ReadOnly]
	private float turn;

	private Rigidbody[] RagdollRbs => null;

	private void OnDespawned()
	{
	}

	private void FixedUpdate()
	{
	}

	[Button(null)]
	public void EnableRagdoll()
	{
	}

	[Button(null)]
	private void ResetRagdoll()
	{
	}

	private void OnDisable()
	{
	}
}
