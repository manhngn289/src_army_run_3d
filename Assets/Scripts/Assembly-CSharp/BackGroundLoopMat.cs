using UnityEngine;
using UnityEngine.UI;

public class BackGroundLoopMat : VectorGameplayBehavior
{
	public Image image;

	public float speed;

	private Material material;

	private float yOffset;

	private float xOffset;

	public MoveDirection moveDirection;

	[SerializeField]
	private bool useWithMask;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
