using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
	[ReadOnly]
	public AllLevelRecordData allLevelRecordData;

	[ReadOnly]
	[SerializeField]
	private SerializableSet gameData;

	[StaticSerialize(typeof(PopupWinLose), "GoldClaimInLevel")]
	public int goldClamInLevel;

	[StaticSerialize(typeof(PopupWinLose), "ElixirClaimInLevel")]
	public int elixirClaimInLevel;

	public LevelLoader levelLoader;

	public static bool IsLosePreviousLevel;

	public static bool IsInterruptLevel;

	private static float _timeLevelStart;

	[SerializeField]
	private bool useRecordData;

	[ReadOnly]
	public bool selectedBuff;

	[SerializeField]
	[Header("Test")]
	private bool isUpdateStatUnit;

	[SerializeField]
	public bool isTestLevel;

	[SerializeField]
	private LevelController levelTest;

	[SerializeField]
	public LevelTemplateData levelTemplateDataTest;

	[SerializeField]
	private bool selfLoading;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private static void OnLowMemory()
	{
	}

	private void OnLevelEnd(bool isWin)
	{
	}

	public void OnWinLoseShow()
	{
	}

	[Button(null)]
	public void Win()
	{
	}

	[Button(null)]
	public void Lose()
	{
	}

	public static void DespawnAllObject(bool hasTroop = false)
	{
	}

	[Button(null)]
	public void LoadLevel(bool isImmediately = false, bool useFadeLevel = true)
	{
	}

	public static void OnLevelLoadDone(bool needTurnOnFade)
	{
	}

	public void ForceLoadLevel()
	{
	}

	private static void ForceResetPlayerData()
	{
	}

	public void StartLevel()
	{
	}

	private void OnLevelStart()
	{
	}

	private static void NewDay()
	{
	}
}
