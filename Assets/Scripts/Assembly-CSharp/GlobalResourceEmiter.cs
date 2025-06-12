using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aluta;
using Coffee.UIExtensions;
using Everest.CustomEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class GlobalResourceEmiter : Singleton<GlobalResourceEmiter>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public bool doneRandom;

		public ResourceEmitTarget targetMove;

		public GlobalResourceEmiter _003C_003E4__this;

		public List<GameObject> objectsMove;

		internal bool _003CMoveAll_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CMoveAll_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResourceEmitTarget targetMove;

		public GlobalResourceEmiter _003C_003E4__this;

		public List<GameObject> objectsMove;

		public EmitResourceData emitResourceData;

		public Transform moveFrom;

		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		public Action firstItemReachTarget;

		public GlobalResourceType globalResourceType;

		private int _003Cindex_003E5__2;

		private List<GameObject>.Enumerator _003C_003E7__wrap2;

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
		public _003CMoveAll_003Ed__40(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CMoveObjectToTarget_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject objectMove;

		public float delayPerItem;

		public AnimationCurve moveCurve;

		public AnimationCurve scaleCurve;

		public float timeMove;

		public Vector3 startPos;

		public Vector3 target;

		public Action moveDone;

		public bool checkFistItemReachTarget;

		public GlobalResourceType resourceType;

		public GlobalResourceEmiter _003C_003E4__this;

		public Action firstItemReachTarget;

		private float _003CelapsedTime_003E5__2;

		private bool _003Cdelayed_003E5__3;

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
		public _003CMoveObjectToTarget_003Ed__47(int _003C_003E1__state)
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

	public static bool NotFirstOpenHome;

	[SerializeField]
	[ReadOnly]
	private List<GameObject> coinsInitialized;

	[SerializeField]
	[ReadOnly]
	private List<GameObject> elixirsInitialized;

	[ReadOnly]
	[SerializeField]
	private List<GameObject> skipItTicketsInitialized;

	[SerializeField]
	private Transform resourceEmitParent;

	[SerializeField]
	private Transform coinPos;

	[SerializeField]
	private Transform elixirPos;

	[SerializeField]
	private Transform playBtn;

	[SerializeField]
	private GameObject coinImgPrefab;

	[SerializeField]
	private GameObject elixirImgPrefab;

	[SerializeField]
	private GameObject skipItTicketImgPrefab;

	[SerializeField]
	private AnimationCurve scaleRadomTargetCurve;

	[SerializeField]
	private AnimationCurve scaleFinalTargetCurve;

	[Header("Move Random Pos")]
	[SerializeField]
	private float minRandomTime;

	[SerializeField]
	private float maxRandomTime;

	[FormerlySerializedAs("speedMoveRandomCurve")]
	[SerializeField]
	private AnimationCurve moveRandomCurve;

	[SerializeField]
	private float ranRadius;

	[SerializeField]
	private float delayAllMoveFinal;

	[SerializeField]
	[FormerlySerializedAs("flightCurve")]
	[Header("Move Final")]
	private AnimationCurve moveFinalTargetCurve;

	[FormerlySerializedAs("flightDuration")]
	public float timeMoveToFinalTarget;

	[SerializeField]
	private float delayperItem;

	public List<EmitResourceData> emitDataPertype;

	[SerializeField]
	[ReadOnly]
	private bool isFirstCoinReachTarget;

	[SerializeField]
	[ReadOnly]
	private bool isFirstElixirReachTarget;

	[ReadOnly]
	[SerializeField]
	private bool isFirstSkipItTicketReachTarget;

	[SerializeField]
	private ResourceEmitTarget coinTargetDefault;

	[SerializeField]
	private ResourceEmitTarget elixirTargetDefault;

	[SerializeField]
	private ResourceEmitTarget skipItTicketTargetDefault;

	[SerializeField]
	private bool newSoundSystem;

	public static EmitType EmitResourceType;

	[SerializeField]
	private float scaleUpTarget;

	[SerializeField]
	private float scaleDownTime;

	[FormerlySerializedAs("scaleUpParticle")]
	[SerializeField]
	private UIParticle scaleUpParticleCoin;

	[FormerlySerializedAs("scaleUpParticle")]
	[SerializeField]
	private UIParticle scaleUpParticleElixir;

	private EmitResourceData EmitResourceData => null;

	[Button(null)]
	private void EmitCoin()
	{
	}

	public void EmitCoin(Transform fromPos, ResourceEmitTarget toPos, Action onComplete)
	{
	}

	[Button(null)]
	private void EmitElixir()
	{
	}

	public void EmitElixir(Transform fromPos, ResourceEmitTarget toPos, Action onComplete)
	{
	}

	[Button(null)]
	private void EmitSkipIt()
	{
	}

	public void EmitSkipIt(Transform fromPos, ResourceEmitTarget toPos, Action onComplete)
	{
	}

	private void Emit(GlobalResourceType resourceType, Transform fromPos, ResourceEmitTarget toPos, Action onComplete)
	{
	}

	private void InitializeResourcesToEmit(GlobalResourceType type)
	{
	}

	[IteratorStateMachine(typeof(_003CMoveAll_003Ed__40))]
	private IEnumerator MoveAll(EmitResourceData emitResourceData, List<GameObject> objectsMove, Transform moveFrom, ResourceEmitTarget targetMove, Action firstItemReachTarget, GlobalResourceType globalResourceType)
	{
		return null;
	}

	private void ScaleTarget(Transform target, UIParticle scaleFX)
	{
	}

	private static void ScaleTarget(ResourceEmitTarget resourceEmitTarget)
	{
	}

	[IteratorStateMachine(typeof(_003CMoveObjectToTarget_003Ed__47))]
	private IEnumerator MoveObjectToTarget(GameObject objectMove, Vector3 startPos, Vector3 target, float timeMove, AnimationCurve moveCurve, AnimationCurve scaleCurve, Action moveDone, float delayPerItem = -1f, bool checkFistItemReachTarget = false, Action firstItemReachTarget = null, GlobalResourceType resourceType = GlobalResourceType.Coin)
	{
		return null;
	}

	public void EmitResource()
	{
	}
}
