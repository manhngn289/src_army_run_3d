using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aluta;
using Everest.CustomEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class LevelLoader : Singleton<LevelLoader>
{
	[CompilerGenerated]
	private sealed class _003CLoadLevel_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelTemplateData levelData;

		public LevelLoader _003C_003E4__this;

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
		public _003CLoadLevel_003Ed__12(int _003C_003E1__state)
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

	[FormerlySerializedAs("decorGOPrefabs")]
	private Dictionary<int, GameObject> decorGosByChapterInitialized;

	[SerializeField]
	private LevelController levelControllerPrefab;

	[SerializeField]
	[FormerlySerializedAs("decorBGFar")]
	private Renderer decorBgFar;

	[SerializeField]
	private Transform decorPoint;

	[SerializeField]
	private Transform levelParent;

	[SerializeField]
	[ReadOnly]
	private LevelController levelTemplate;

	[DisplayAsString]
	public LevelController CurrentLevel { get; private set; }

	protected override void Awake()
	{
	}

	private void InitLevelEmpty()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadLevel_003Ed__12))]
	public IEnumerator LoadLevel(LevelTemplateData levelData)
	{
		return null;
	}

	public void LoadLevel(LevelController levelTest)
	{
	}

	private void InitDecor()
	{
	}

	public static ChapterSettingDataSO LoadChapterSettingDataSo(int chapterID)
	{
		return null;
	}

	public static AllRecordableObjectSO LoadAllRecordableObjectSo()
	{
		return null;
	}

	public static void UnloadSetting(UnityEngine.Object objectToUnload)
	{
	}
}
