using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aluta;
using Everest.CustomEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class LevelController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public ModuleControllerRecordData dataModule;

		internal bool _003CCreateLevelFromData_003Eb__0(ModuleModel m)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public ModuleControllerRecordData dataModule;

		internal bool _003CCreateLevelFromDataRevive_003Eb__0(ModuleModel m)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCreateLevelFromData_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelController _003C_003E4__this;

		public ChapterSettingDataSO chapterData;

		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		private AllRecordableObjectSO _003CallRecordableObjectSo_003E5__2;

		private ModuleController _003CmoduleControllerPrefab_003E5__3;

		private LevelModulesSO _003CmoduleModels_003E5__4;

		private int _003Ci_003E5__5;

		private ModuleController _003CmoduleController_003E5__6;

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
		public _003CCreateLevelFromData_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CCreateLevelFromDataRevive_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelController _003C_003E4__this;

		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		private ChapterSettingDataSO _003CchapterData_003E5__2;

		private AllRecordableObjectSO _003CallRecordableObjectSo_003E5__3;

		private LevelModulesSO _003CmoduleModels_003E5__4;

		private ModuleController _003CmoduleControllerPrefab_003E5__5;

		private int _003Ci_003E5__6;

		private List<ObjectRecordDataSO> _003CutilityInModule_003E5__7;

		private ModuleController _003CmoduleController_003E5__8;

		private List<ObjectRecordDataSO>.Enumerator _003C_003E7__wrap8;

		private ObjectRecordDataSO _003CtrapData_003E5__10;

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
		public _003CCreateLevelFromDataRevive_003Ed__24(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CInitLevelWithData_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelController _003C_003E4__this;

		public LevelTemplateData levelTemplateDataRecorded;

		public ChapterSettingDataSO chapterSetting;

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
		public _003CInitLevelWithData_003Ed__16(int _003C_003E1__state)
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

	[FormerlySerializedAs("chapterID")]
	public int mapSettingID;

	public FinishLevel finishLevel;

	public GateController gateController;

	public UtilityTrapController utilityTrapController;

	[SerializeField]
	private ModuleController[] moduleControllers;

	[SerializeField]
	private Transform finishLevelParent;

	[SerializeField]
	private Transform moduleParent;

	[SerializeField]
	[FormerlySerializedAs("utilityMoveSpeed")]
	private Transform utilityMoveSpeedPos;

	private PlayerManager playerManager;

	private Transform playerManagerTr;

	public bool runCoin;

	public bool hasVIP;

	[SerializeField]
	[Header("Creat Level Runtime")]
	public LevelTemplateData levelTemplateData;

	[ReadOnly]
	public List<ModuleControllerRecordData> moduleControllerRecordDatas;

	[SerializeField]
	private List<ModuleController> moduleControllersInited;

	public static int CacheModuleIndex;

	private ModuleController[] ModuleControllers => null;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CInitLevelWithData_003Ed__16))]
	public IEnumerator InitLevelWithData(LevelTemplateData levelTemplateDataRecorded, ChapterSettingDataSO chapterSetting)
	{
		return null;
	}

	public List<ModuleControllerRecordData> RecordModules(string path)
	{
		return null;
	}

	public List<MoveSpeedUtilityRecordDataSO> RecordSpeedUpUtility(string path)
	{
		return null;
	}

	public bool RecordTutorial(out TutorialRecordData tutorialRecordData)
	{
		tutorialRecordData = null;
		return false;
	}

	[IteratorStateMachine(typeof(_003CCreateLevelFromData_003Ed__22))]
	[Button(null)]
	private IEnumerator CreateLevelFromData(ChapterSettingDataSO chapterData)
	{
		return null;
	}

	[Button(null)]
	private void ClearModuleRevive()
	{
	}

	[IteratorStateMachine(typeof(_003CCreateLevelFromDataRevive_003Ed__24))]
	private IEnumerator CreateLevelFromDataRevive()
	{
		return null;
	}

	[Button(null)]
	public void ClearLevel()
	{
	}

	[Button(null)]
	public void ResetLevelFromModule()
	{
	}
}
