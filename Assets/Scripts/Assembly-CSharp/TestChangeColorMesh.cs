using System.Collections.Generic;
using UnityEngine;

public class TestChangeColorMesh : MonoBehaviour
{
	[SerializeField]
	private MeshFilter meshFilter;

	[SerializeField]
	private Color[] colors;

	[SerializeField]
	private Color[] colors1;

	[SerializeField]
	private Color[] colors2;

	private Mesh mesh;

	private List<Color[]> listColors;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void ChangeRandomColor()
	{
	}
}
