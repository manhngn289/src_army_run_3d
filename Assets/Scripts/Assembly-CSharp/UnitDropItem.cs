using System.Collections.Generic;
using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class UnitDropItem : MonoBehaviour
{
	[SerializeField]
	private bool selfInit;

	[ReadOnly]
	[SerializeField]
	private bool isInitialized;

	[SerializeField]
	[ReadOnly]
	private float currentDmgTaken;

	public TakeDmgType type;

	public AttackerType dmgSourceTake;

	[SerializeField]
	private float dmgThreshold;

	[SerializeField]
	private UnitHealth unitHealth;

	[SerializeField]
	private bool dropItemOnTakeDmg;

	[SerializeField]
	private bool dropItemOnDead;

	[SerializeField]
	private DropItemData itemDropInOnTakeEnoughDmg;

	[SerializeField]
	private List<DropItemData> dropItemOnDeadDatas;

	[SerializeField]
	private float delayTime;

	[DisplayAsString]
	private float DmgThreshold => 0f;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSpawned()
	{
	}

	private void InitAction()
	{
	}

	private void OnDespawned()
	{
	}

	private void OnTakeEnoughDmg(DamageInfo dmgInfo, UnitHealth unitHealthTakeDmg)
	{
	}

	private void DropItemByRate(AttackerType attackerType, DropItemData dropItemData)
	{
	}

	private void DropItem(GameObject itemDrop, float delay = 0f)
	{
	}
}
