using Aluta;
using UnityEngine;

public class BuildingTransparent : MonoBehaviour
{
	[SerializeField]
	private Material transparentMat;

	[SerializeField]
	private Renderer[] buildingRender;

	[ReadOnly]
	[SerializeField]
	private Material defaultMat;

	public bool isTransparent;

	private void OnValidate()
	{
	}

	private void Start()
	{
	}

	public void TurnTransparent()
	{
	}

	public void TurnDefault()
	{
	}
}
