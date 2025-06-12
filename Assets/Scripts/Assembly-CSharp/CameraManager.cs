using System;
using Aluta;
using Cinemachine;
using Everest.CustomEditor;
using UnityEngine;

public class CameraManager : Singleton<CameraManager>
{
	private bool isBattling;

	[SerializeField]
	private CinemachineBrain brain;

	[SerializeField]
	private CinemachineVirtualCamera[] allFollowCamera;

	[SerializeField]
	private CameraFollowType currentCameraActive;

	[SerializeField]
	private CinemachineTargetGroup targetGroup;

	[SerializeField]
	private TurnBuildingTransparentController buildingTransparentController;

	[SerializeField]
	private BossPhaseCameraSetting bossPhaseCameraSetting;

	[Button(null)]
	public void ChangeBattleCamera()
	{
	}

	[Button(null)]
	public void ChangeNormalCamera()
	{
	}

	public void ChangeNormalCamera(CinemachineVirtualCamera cameraFrom = null, Action changeCamDone = null)
	{
	}

	public void ChangeFreeCamera(Action onChangeCamDone)
	{
	}

	public void SetTargetGroup(Transform targetBoss)
	{
	}

	[Button(null)]
	public void ChangeCameraToDefaultHomePos()
	{
	}

	private void ActiveCamera(CameraFollowType type, CinemachineVirtualCamera cameraFrom = null, Action changeCamDone = null)
	{
	}

	public void ChangeCameraToDefaultNormalPos(Action changeCamDone)
	{
	}

	public void DeactiveAllCam()
	{
	}

	public void ActiveCurrentCam()
	{
	}
}
