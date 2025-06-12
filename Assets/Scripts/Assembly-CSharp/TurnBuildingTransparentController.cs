using System.Collections.Generic;
using Aluta;
using UnityEngine;

public class TurnBuildingTransparentController : MonoBehaviour
{
	[ReadOnly]
	[SerializeField]
	private List<BuildingTransparent> buildingBlockCameras;

	[SerializeField]
	private LayerMask buildingTransparentLayer;

	[SerializeField]
	private float distanceCheck;

	private RaycastHit[] buildingHits;

	private Ray cameraRay;

	private Camera mainCam;

	public bool active;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void CheckBuildingBlockCamera()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
