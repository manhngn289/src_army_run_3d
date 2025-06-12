using System;
using UnityEngine.Serialization;

[Serializable]
public class EmitResourceData
{
	public EmitType emitType;

	[FormerlySerializedAs("emitCoinAmount")]
	public int emitAmount;

	public float delayperItem;
}
