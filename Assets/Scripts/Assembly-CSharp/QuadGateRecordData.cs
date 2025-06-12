using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class QuadGateRecordData
{
	public bool useManualSetting;

	public List<Vector2Int> gateValue;

	public bool isDeactiveSecondGate;

	[EnumTuple(typeof(GateType), typeof(GateType), "Left", "Right")]
	public List<SerializableEnumTuple<GateType, GateType>> gateTypeValues;

	public Vector3 localPosition;

	public Quaternion localRotation;

	public void Record(QuadGates quadGates)
	{
	}
}
