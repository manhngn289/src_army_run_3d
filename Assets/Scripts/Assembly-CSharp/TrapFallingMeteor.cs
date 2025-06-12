using Cinemachine;
using Everest.CustomEditor;
using UnityEngine;

public class TrapFallingMeteor : TrapCheckPlayer, IObjectCanRecord
{
	[SerializeField]
	protected GameObject[] trapModels;

	[SerializeField]
	private ParticleSystem[] fallingDoneFXs;

	[SerializeField]
	private CinemachineImpulseSource impulseSource;

	public float fallingTime;

	[SerializeField]
	private Vector3 initPos;

	[SerializeField]
	private TrapFallingMeteorRecordDataSO trapFallingMeteorRecordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	private void OnEnable()
	{
	}

	[Button(null)]
	protected override void OnPlayerInRadius()
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
