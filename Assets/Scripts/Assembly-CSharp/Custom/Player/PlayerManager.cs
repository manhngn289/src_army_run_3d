using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aluta;
using Everest.CustomEditor;
using PathologicalGames;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : Singleton<PlayerManager>, ICanCollision
{
	public const float CHECK_ENEMY_CHANGE_CAM = 40f;

	public const float CHECK_ENEMY_ACTIVE_ATTACK = 24f;

	private const int DEFAULT_SPAWN_POS = 30;

	private const float TIME_SHOW_TROOP_COUNT = 5f;

	[Header("PLAYER MANAGERS")]
	public PlayerMovementController playerMovementController;

	public PlayerPowerUpManager playerPowerUpManager;

	public PlayerHomeAnimationController playerHomeAnimationController;

	[Header("PLAYER SETTING")]
	[Header("Troops")]
	[SerializeField]
	[ReadOnly]
	private List<UnitAllyController> trooperList;

	[SerializeField]
	[ReadOnly]
	private UnitAllyController escortTrooper;

	[SerializeField]
	private AllyTroopDataSO troopPrefabs;

	[SerializeField]
	private AllyTroopDataSO vipPrefabs;

	[SerializeField]
	private int trooperChangeThreshold;

	private int troopDeadCheck;

	public int troopEvolveLevel;

	[Header("Troop Points")]
	[SerializeField]
	[ReadOnly]
	private int highestCircleHasTroop;

	private Dictionary<int, List<TroopPoint>> troopPointDic;

	private Dictionary<int, List<Vector3>> allCirclePos;

	[Range(0.001f, 0.2f)]
	[SerializeField]
	private float minRange;

	[SerializeField]
	private float defaultRadiusTroop;

	[SerializeField]
	private int circleID;

	[SerializeField]
	private Transform troopPointParent;

	[SerializeField]
	private TroopPoint troopPointPrefab;

	[SerializeField]
	private TroopPoint vipPoint;

	[Header("Home Troop")]
	public Transform homeTroopPoint;

	[SerializeField]
	private GameObject[] homeTroops;

	[SerializeField]
	private Vector3 homeTroopRotation;

	[SerializeField]
	[Header("Troop Count UI")]
	private CanvasGroup troopCountUIAlpha;

	[SerializeField]
	private Image troopCountUIBgImg;

	[SerializeField]
	private TMP_Text troopCountTxt;

	[ReadOnly]
	public AttackType currentAttackType;

	public float allyScaleCheckItemDropRadius;

	private SpawnPool troopPool;

	public Action TrooperQuantityIncrease;

	public Action TrooperQuantityDecrease;

	public Action<float> UpdateCircleTroopAction;

	private Coroutine updateTroopPosAuto;

	private bool showingTroopCount;

	private Coroutine waitHideTroopCountUICor;

	private bool canShowTroopCountUI;

	[SerializeField]
	private Color troopCountUIInitColor;

	[SerializeField]
	private Color troopCountUIIncreaseColor;

	[SerializeField]
	private Color troopCountUIDecreaseColor;

	[SerializeField]
	private float timeFadeInit;

	public Action TroopMoveGoalDone;

	[SerializeField]
	private ParticleSystem coinEndGame;

	private Coroutine waitUpdatePos;

	[Header("PLAYER STATUS")]
	[ReadOnly]
	public bool startLevel;

	[ReadOnly]
	public bool hasEnemyInRange;

	[ReadOnly]
	public bool hasTrapCanDestroyInRange;

	[ReadOnly]
	public bool startAttack;

	[ReadOnly]
	public bool battleCamWithEnemy;

	[ReadOnly]
	public bool battleCamWithTrapUtility;

	[ReadOnly]
	public bool battleCam;

	[SerializeField]
	[ReadOnly]
	private bool isLose;

	[SerializeField]
	private float delayChangeCamBattleToNormal;

	[SerializeField]
	[ReadOnly]
	private float currentDelayChangeCamBattleToNormal;

	[Header("ICE/FIRE GRENADE BUFF")]
	[SerializeField]
	private GameObject iceGrenadePrefab;

	[SerializeField]
	private GameObject fireGrenadePrefab;

	[SerializeField]
	[ReadOnly]
	private float currentDelayThrowIceGrenadeTime;

	[SerializeField]
	[ReadOnly]
	private float currentDelayThrowFireGrenadeTime;

	[Header("KEY DOOR")]
	[SerializeField]
	private TrapKeysAndDoorKeyFireGO keyOpenDoorPrefab;

	[SerializeField]
	private Transform keyFirePoint;

	[SerializeField]
	private float delayBetweenKey;

	[ReadOnly]
	public int keyUnlockDoorHas;

	[Header("REVIVE")]
	[ReadOnly]
	public bool canRevive;

	[Header("REVIVE")]
	[ReadOnly]
	public bool hasCacheForRevive;

	[SerializeField]
	[Header("TEST")]
	private int testAmount;

	[SerializeField]
	private bool testAttack;

	[SerializeField]
	private bool testCam;

	public bool showGizmo;

	[SerializeField]
	private float timeEnableAttack;

	[SerializeField]
	private PlayerCacheStatus playerCacheStatus;

	[SerializeField]
	private float reviveImmortalDuration;

	[SerializeField]
	private CollisionSetting collisionSetting;

	public List<UnitAllyController> TrooperList => null;

	private UnitAllyController TrooperPrefab => null;

	[DisplayAsString]
	public float OffsetLimitX => 0f;

	private bool IsLose => false;

	public int TroopsCount => 0;

	private static int InitTroopAmount => 0;

	public ColliderType ColliderType => default(ColliderType);

	public ColliderShape Shape => default(ColliderShape);

	public MonoBehaviour SelfBehaviour => null;

	public LayerMask SelfLayer => default(LayerMask);

	public LayerMask CollisionLayer => default(LayerMask);

	public Vector3 Position => default(Vector3);

	public Quaternion Rotation => default(Quaternion);

	public Vector3 CenterOffset => default(Vector3);

	public float SphereRadius => 0f;

	public Vector3 BoxSize => default(Vector3);

	public bool IsActionOnNotCollision => false;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void AddDefaultTroopOnStart()
	{
	}

	public void ResetSomePlayerInfo(bool addDefaultTroop = true)
	{
	}

	public void PlayerResetImmediate()
	{
	}

	public void StartLevel()
	{
	}

	private void ChangeRunNoWeapon()
	{
	}

	private void ChangeRunWeapon()
	{
	}

	public void ActiveTroopInGame()
	{
	}

	public void RotateTroopHomeToRoad()
	{
	}

	public void ActiveTroopHome()
	{
	}

	private void AutoUpdateTroopPos()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoUpdateTroopPosCor_003Ed__60))]
	private IEnumerator AutoUpdateTroopPosCor()
	{
		return null;
	}

	private void UpdateCircleTroop()
	{
	}

	public void AddTrooper(GateType gateType, int value)
	{
	}

	public void AddTrooper(int value, GateType gateType, bool useFX = true)
	{
	}

	private void CreateTroopPoint()
	{
	}

	private void TroopDead(UnitAllyController unitAliveDead)
	{
	}

	private void InitDefaultTroopPos()
	{
	}

	private void CreateTrooper(int quantity, bool useFX)
	{
	}

	[Button(null)]
	public void TestEvolve()
	{
	}

	public void EvolveTroop(int levelEvolve)
	{
	}

	private void AddVip()
	{
	}

	public void IncreaseCollectItemDropRadius(float value)
	{
	}

	private void KillTrooper(int quantity)
	{
	}

	private void ShowTroopCountUILostTroop()
	{
	}

	private void ShowTroopCountUIAddTroop()
	{
	}

	private void ShowTroopCountUISpecial(bool isAddTroop)
	{
	}

	private void ShowTroopCountUINormal()
	{
	}

	private void HideTroopCountUI()
	{
	}

	public void FinishLevel(FinishType finishType, Vector3 goalPoint, FinishVehicle finishVehicle = null)
	{
	}

	private void TroopMoveToGoalPoint(Vector3 goalPoint, FinishVehicle finishVehicle)
	{
	}

	private void Update()
	{
	}

	private void CheckLose()
	{
	}

	public void Lose(bool isDelay = true)
	{
	}

	public void AllAliveMoveAnim()
	{
	}

	public void DisableController()
	{
	}

	public void DisableMoveForward()
	{
	}

	private void EnableController()
	{
	}

	private void ActiveBossFight()
	{
	}

	private void ChangeBossFight()
	{
	}

	private void ChangeTroopAttackType(AttackType attackType)
	{
	}

	public void ChangePlayerCollectItemDrop(float scale)
	{
	}

	private Vector3 Circle(float angle, float defaultRadius)
	{
		return default(Vector3);
	}

	private List<Vector3> FindPosInCircle(float unitMinRange, float defaultRadius)
	{
		return null;
	}

	private List<Vector3> FindPosInCircle(float unitMinRange, float defaultRadius, int circlePosID)
	{
		return null;
	}

	private Dictionary<int, List<Vector3>> FindAllPosWithRequest(int request, float unitMinRange, float defaultRadius)
	{
		return null;
	}

	private TroopPoint GetTroopPointEmpty()
	{
		return null;
	}

	private void UpdateTroopPos()
	{
	}

	private void DelayUpdateTroopPos()
	{
	}

	private void FixedUpdate()
	{
	}

	public void TakeKey()
	{
	}

	public void FireKeyUnlockDoor(int fireAmount, Transform pointOpenDoor, TrapKeysAndDoor doorNeedKey)
	{
	}

	public static DamageInfo GetTroopDmg()
	{
		return null;
	}

	private void ThrowIceGrenade()
	{
	}

	private void ThrowFireGrenade()
	{
	}

	private void GetGrenade(bool isFireGrenade)
	{
	}

	public void ActiveMissile(bool isFree, bool isForceActive)
	{
	}

	public void Revive()
	{
	}

	[Button(null)]
	private void TestImmortalAllTroop()
	{
	}

	private void ImmortalAllTroop(bool useFx = true)
	{
	}

	[Button(null)]
	private void OffImmortalAllTroop()
	{
	}

	[Button(null)]
	private void KillTroop()
	{
	}

	[Button(null)]
	private void EnableAttackInTime()
	{
	}

	public void ResetAllTroopBuffDeBuffUtility()
	{
	}

	public void ResetAllTroopToDefaultBullet()
	{
	}

	public void CachePlayerStatus()
	{
	}

	private void ApplyPlayerCacheStatus()
	{
	}

	public void ReActiveMovement()
	{
	}

	public void ImmortalAfterRevive()
	{
	}

	public void OnNotCollision()
	{
	}

	public void OnCollision(ICanCollision objectCollisionWith)
	{
	}

	public void UnregisterCollision()
	{
	}

	protected void OnDrawGizmosSelected()
	{
	}
}
