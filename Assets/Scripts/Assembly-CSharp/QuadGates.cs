using System.Collections.Generic;
using Aluta;
using UnityEngine;
using UnityEngine.Serialization;

public class QuadGates : MonoBehaviour
{
	private const float DISTANCE_UPDATE_GATE = 15f;

	[SerializeField]
	private DoubleGate[] doubleGates;

	[FormerlySerializedAs("useOverideLimit")]
	[SerializeField]
	private bool useOverrideLimit;

	[SerializeField]
	[FormerlySerializedAs("overideLimitValue")]
	private int overrideLimitValue;

	[Header("MANUAL SETTING")]
	public bool useManualSetting;

	public List<Vector2Int> gateValue;

	[EnumTuple(typeof(GateType), typeof(GateType), "Left", "Right")]
	public List<SerializableEnumTuple<GateType, GateType>> gateTypeValues;

	[ReadOnly]
	[SerializeField]
	private int gateDone;

	[SerializeField]
	private float distanceBetweenGroup;

	[SerializeField]
	private QuadGateRecordData recordData;

	[Header("TEST")]
	public int trooperCountTest;

	public int totalValue;

	[SerializeField]
	private bool isTest;

	public DoubleGate[] DoubleGates => null;

	public QuadGateRecordData QuadGateRecordData => null;

	private void SetFixedValueOnGate(List<Vector2Int> gateValue, List<SerializableEnumTuple<GateType, GateType>> gateTypes)
	{
	}

	public void CheckDisableGate()
	{
	}

	private void OnValidate()
	{
	}

	private void UpdateGatePos()
	{
	}

	private void ResizeGateValue()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void RecoverFromData(QuadGateRecordData recordDataToRecover)
	{
	}
}
