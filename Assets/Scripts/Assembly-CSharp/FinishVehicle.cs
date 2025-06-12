using Cinemachine;
using Everest.CustomEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class FinishVehicle : MonoBehaviour
{
	public CinemachineVirtualCamera camFollowVehicle;

	[SerializeField]
	private Transform lookAtPoint;

	[SerializeField]
	private FinishVehicleType finishVehicleType;

	[SerializeField]
	private Animator vehicleAnimator;

	[SerializeField]
	private Transform vehicleModel;

	[FormerlySerializedAs("scaleX")]
	[SerializeField]
	private float scaleUp;

	[FormerlySerializedAs("timeScaleX")]
	[SerializeField]
	private float timeScaleUp;

	[SerializeField]
	[FormerlySerializedAs("scaleDownY")]
	private float scaleDown;

	[SerializeField]
	[FormerlySerializedAs("timeScaleY")]
	private float timeScaleDown;

	private void OnEnable()
	{
	}

	public void FinishMove()
	{
	}

	[Button(null)]
	private void MoveStraight()
	{
	}

	public void TroopIn()
	{
	}

	[Button(null)]
	private void ScaleTroopIn()
	{
	}

	[Button(null)]
	public void DisableLookAt()
	{
	}

	private void OnDestroy()
	{
	}
}
