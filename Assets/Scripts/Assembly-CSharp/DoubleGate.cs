using UnityEngine;

public class DoubleGate : MonoBehaviour
{
	private static readonly int[] MultiplyValue;

	public Gate[] gates;

	[SerializeField]
	private QuadGates quadGates;

	[SerializeField]
	private float distanceBetweenGate;

	[SerializeField]
	private int totalValue;

	private GateValue highesValue;

	[SerializeField]
	private bool test;

	public GateValue HighesValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void OnValidate()
	{
	}

	public void SetFixedValue(Vector2Int value, SerializableEnumTuple<GateType, GateType> gateTypeValue)
	{
	}

	public void DisableOther(Gate gateUsed)
	{
	}

	public void SetGateData(int totalValue, int valueChange, QuadGates quad)
	{
	}

	private GateValue[] CalculateGateValue(int totalValue, int valueChangeMax)
	{
		return null;
	}
}
