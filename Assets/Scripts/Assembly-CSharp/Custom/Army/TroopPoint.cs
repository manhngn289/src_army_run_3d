using Aluta;
using UnityEngine;

public class TroopPoint : MonoBehaviour
{
	public int circleID;

	public int pointID;

	[SerializeField]
	private Vector3 selfPos;

	[ReadOnly]
	[SerializeField]
	private UnitAllyController aliveControllerInPoint;

	[SerializeField]
	private ParticleSystem immortalShieldFxPrefab;

	private const float REPOSITION_TIME = 0.2f;

	private float currentTimeReposition;

	[ReadOnly]
	[SerializeField]
	private ParticleSystem immortalShieldFx;

	public bool Empty => false;

	public void InitData(int id, int pointId, Vector3 pos)
	{
	}

	private void LateUpdate()
	{
	}

	public void ActiveImmortalEffect()
	{
	}

	public void DeActiveImmortalEffect()
	{
	}

	public void SetUnitInPoint(UnitAllyController unitAliveController)
	{
	}

	public void RemoveAliveInPoint()
	{
	}

	public void SwapUnit(TroopPoint other)
	{
	}

	private void Relocation()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
