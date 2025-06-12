using Cinemachine;
using Everest.CustomEditor;
using TMPro;
using UnityEngine;

public class TrapKeysAndDoor : MonoBehaviour, IChangeCamBattle, IObjectCanRecord
{
	public Transform pointTakeKeys;

	public int keysRequired;

	[SerializeField]
	private TMP_Text currentKeysRequiredTxt;

	[SerializeField]
	private float distanceCheckPlayer;

	[SerializeField]
	private int currentKeyRequired;

	[SerializeField]
	private CinemachineImpulseSource impulseSourceStartOpenDoor;

	[SerializeField]
	private CinemachineImpulseSource impulseSourceEndOpenDoor;

	[SerializeField]
	private TrapKeysAndDoorRecordDataSO trapKeysAndDoorRecordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	public IChangeBattleCamActivePlayerAttackManager Manager { get; set; }

	private void OnEnable()
	{
	}

	private void MakePlayerGiveKey()
	{
	}

	public void TakeKey()
	{
	}

	[Button(null)]
	private void OpenDoor()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void OnDisable()
	{
	}

	public void OnObjectDestroyed()
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
