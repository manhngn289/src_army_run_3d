using System.Collections.Generic;
using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class UtilityGTOilDrum : UtilityDestroyable, IObjectCanRecord
{
	[ReadOnly]
	[SerializeField]
	private bool startMove;

	[ReadOnly]
	public bool canMove;

	[Header("GENERAL")]
	public DrumType drumType;

	public DrumMode drumMode;

	[Range(1f, 3f)]
	public int troopInUtility;

	public float speed;

	public TrapCheckPlayer trapCheckPlayer;

	[SerializeField]
	private List<GameObject> troopsInUtility;

	[SerializeField]
	private List<Animator> troopsInUtilityAnimator;

	[SerializeField]
	private Vector3[] twoTroopLayout;

	[SerializeField]
	private Vector3[] threeTroopLayout;

	[SerializeField]
	private GameObject[] drumObjectsCanTake;

	[SerializeField]
	private WeaponJumpToPlayer weaponJumpToPlayer;

	[SerializeField]
	private TroopJumpToPlayer troopJumpToPlayer;

	[Header("SINGLE")]
	[SerializeField]
	private UtilityGTOilDrumTemp barrelRoot;

	[Header("MULTIPLE")]
	public List<int> hpPerBarrelTemps;

	[SerializeField]
	private float drumHeight;

	[SerializeField]
	private UtilityGTOilDrumTemp barrelTempPrefab;

	[SerializeField]
	private OilDrumCheckGround oilDrumCheckGround;

	[SerializeField]
	[ReadOnly]
	private List<UtilityGTOilDrumTemp> barrelsTempInitialized;

	[ReadOnly]
	public int currentBarrelDestroy;

	private const float OFF_SET_HEIGHT = 0.5f;

	[Header("Record Data")]
	[SerializeField]
	private OilDrumRecordDataSO oilDrumRecordData;

	[SerializeField]
	private ObjectRecordableDataType objectRecordableDataType;

	[DisplayAsString]
	private UtilityGTOilDrumTemp CurrentBarrel => null;

	protected override void Init()
	{
	}

	private void InitMultiOilDrum()
	{
	}

	private void InitItemVisual()
	{
	}

	private void UpdateAnimMultipleBarrels()
	{
	}

	private void FixedUpdate()
	{
	}

	public void DespawnBarrel()
	{
	}

	public void ActiveMove()
	{
	}

	public override void TakeDmg(DamageInfo damageInfo, KillAllyType killAllyType)
	{
	}

	public void OnTempBarrelDestroy()
	{
	}

	protected override void OnUtilityDestroyed()
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
