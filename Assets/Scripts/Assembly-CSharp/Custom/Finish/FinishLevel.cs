using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aluta;
using Everest.CustomEditor;
using UnityEngine;
using UnityEngine.Playables;

public class FinishLevel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CIntroduceBoss_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerManager player;

		public FinishLevel _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CIntroduceBoss_003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitPlayerToInitBoss_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FinishLevel _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitPlayerToInitBoss_003Ed__33(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public FinishType finishType;

	public Transform finishCollider;

	[SerializeField]
	private ModuleController moduleControllerPrefab;

	[SerializeField]
	private Transform playerPoint;

	[SerializeField]
	private Transform finishModuleParent;

	[SerializeField]
	private Transform vehicleFinishPoint;

	[SerializeField]
	private FinishVehicle helicopterGO;

	[SerializeField]
	private FinishVehicle truckGO;

	[SerializeField]
	private Transform goalPoint;

	[ReadOnly]
	public FinishVehicle finishVehicle;

	[Header("BOSS FIGHT")]
	public GameObject bossPrefab;

	[SerializeField]
	private Transform bossAreaPoint;

	[SerializeField]
	private Transform bossAreaRandomBGPoint;

	[SerializeField]
	private Transform bossPoint;

	[SerializeField]
	private UnitEnemyController bossLevel;

	[SerializeField]
	private GameObject camIntroBoss;

	[SerializeField]
	private ModuleController bossModule;

	public bool spawnEnemyWithBoss;

	[SerializeField]
	private Vector3 bossFieldSize;

	[SerializeField]
	private FinishLevelDropUtility finishLevelDropUtility;

	private const float OFF_SET_FINISH_LONG = 20f;

	private bool isSpawnBoss;

	private bool isOpenBossSound;

	private Coroutine delayWin;

	[SerializeField]
	private FinishLevelRecordData finishRecordData;

	[SerializeField]
	private PlayableDirector bossIntroDirector;

	[SerializeField]
	private Transform leftIntroCamera;

	[SerializeField]
	private Transform rightIntroCamera;

	public Vector2 leftRightIntroCamDistance;

	public float FinishLong => 0f;

	public void CreateFinishLevelArea(List<ModuleModel> templateModule)
	{
	}

	public void CreateFinishLevelArea(ModuleController bossAreaPrefab, List<ModuleModel> templateModule)
	{
	}

	public void CreateFinishBossRandom(List<ModuleModel> templateModule, bool clearRandom = false)
	{
	}

	private void ClearFinish()
	{
	}

	public List<ModuleController> GetModuleRandom()
	{
		return null;
	}

	public ModuleController BossFinishModule()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	public void InitFinishDone()
	{
	}

	private void SpawnBoss()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitPlayerToInitBoss_003Ed__33))]
	private IEnumerator WaitPlayerToInitBoss()
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDefeatedBoss(AttackerType type)
	{
	}

	private void InitBoss()
	{
	}

	public void OnPlayerReachFinish(PlayerManager player)
	{
	}

	[IteratorStateMachine(typeof(_003CIntroduceBoss_003Ed__41))]
	private IEnumerator IntroduceBoss(PlayerManager player)
	{
		return null;
	}

	public void ActiveBossTaunt()
	{
	}

	public void ActivePlayerController()
	{
	}

	public void StartFightBoss()
	{
	}

	private void FinishVehicleMove()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public FinishLevelRecordData Record()
	{
		return null;
	}

	public void RecoverFromData(FinishLevelRecordData finishLevelRecordData, ChapterSettingDataSO chapterSetting)
	{
	}

	[Button(null)]
	private void PlayIntroBoss()
	{
	}
}
