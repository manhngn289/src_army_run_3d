using System.Collections.Generic;
using UnityEngine;

public class TrapBombBard : TrapCheckPlayer, IObjectCanRecord
{
	private const float OFF_SET_MODEL = 2.5f;

	public float dmgMaxHpPercent;

	public float dmgRadius;

	public float delayTime;

	[SerializeField]
	private GameObject[] trapModels;

	[SerializeField]
	private Vector3 initPosBombBard;

	[SerializeField]
	private ParticleSystem dealDmgFX;

	[SerializeField]
	private GameObject bombGO;

	[SerializeField]
	private float rotateWarningTime;

	[SerializeField]
	private LayerMask targetLayer;

	private readonly DamageInfo dmg;

	[SerializeField]
	private TrapBombBardRecordDataSO trapBombBardRecordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	private Vector3 ScaleWarning => default(Vector3);

	protected void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	protected override void OnPlayerInRadius()
	{
	}

	protected override void OnPlayerPassing()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void WaitToDropBomb()
	{
	}

	private void DealAoeDmg()
	{
	}

	private void OnOverlapComplete(List<ICanCollision> overlappedObjects)
	{
	}

	public IRecordData DataRecord(string path, int index)
	{
		return null;
	}

	public void RecoverFromData(IRecordData objectRecordData)
	{
	}

	public void RecoverFromDataFallback()
	{
	}
}
