using Aluta;
using UnityEngine;

public class TrapSharkDecor : MonoBehaviour
{
	[SerializeField]
	private Vector3 limitMove;

	private Coroutine moveCoroutine;

	[ReadOnly]
	[SerializeField]
	private Vector3 randomPos;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float rotateSpeed;

	[SerializeField]
	private float dashTime;

	[SerializeField]
	private float currentDashTime;

	public void SetData(Vector3 limit)
	{
	}

	private void OnEnable()
	{
	}

	private void MoveRandomly()
	{
	}

	private void OnDisable()
	{
	}
}
