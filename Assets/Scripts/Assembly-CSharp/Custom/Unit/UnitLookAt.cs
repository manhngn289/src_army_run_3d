using Aluta;
using UnityEngine;

public class UnitLookAt : MonoBehaviour
{
	[SerializeField]
	protected bool selfInit;

	[ReadOnly]
	[SerializeField]
	private UnitStatInfo target;

	[ReadOnly]
	[SerializeField]
	private Vector3 targetDir;

	[SerializeField]
	[ReadOnly]
	private bool lookForward;

	[SerializeField]
	private bool lockAxis;

	[SerializeField]
	private LookAxis lockedAxis;

	[SerializeField]
	private Vector3 defaultDir;

	public bool dirPriority;

	public bool active;

	private Vector3 TargetDir => default(Vector3);

	public void SetDirPriority(bool priority)
	{
	}

	private void OnDespawned()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void SetTarget(UnitStatInfo target)
	{
	}

	public void SetTarget(Vector3 target)
	{
	}

	public void SetLookForward()
	{
	}

	public void SetLookFree()
	{
	}

	private void PerformLookAt()
	{
	}
}
