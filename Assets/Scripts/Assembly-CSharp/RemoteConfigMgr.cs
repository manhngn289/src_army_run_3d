using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using HiGame;

public class RemoteConfigMgr : Singleton<RemoteConfigMgr>
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAsyncInit_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public RemoteConfigMgr _003C_003E4__this;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public const string INTER_AD_CAPPING_TIME = "inter_ad_capping_time";

	public const string INTER_AD_CAPPING_LEVEL = "inter_ad_capping_level";

	public const string OPEN_AD_CAPPING_TIME = "open_ad_capping_time";

	public const string OPEN_AD_ID = "open_ad_id";

	public const string NATIVE_AD_ID = "native_ad_id";

	public const string MREC_AD_ID = "mrec_ad_id";

	public const string OPEN_AD_ON_OFF = "open_ad_on_off";

	public const string BANNER_AD_ON_OFF = "banner_ad_on_off";

	public const string NATIVE_AD_ON_OFF = "native_ad_on_off";

	public const string MREC_AD_ON_OFF = "mrec_ad_on_off";

	public const string INTER_AD_ON_OFF = "inter_ad_on_off";

	public const string LEVEL_SHOW_RATE = "level_show_rate";

	public const string SHOW_RATE_OFF_COUNTRY = "show_rate_off_country";

	public const string ON_OFF_INTERNET_CHECKING = "on_off_internet_checking";

	public const string TIME_AUTO_CLOSE_COLLAP_BANNER = "time_auto_close_collap_banner";

	public const string TIME_REFRESH_BANNER = "time_refresh_banner";

	public const string ON_OFF_COLLAP = "on_off_collap";

	public const string UNLOCK_BY_REWARDED = "unlock_by_rewarded";

	public const string FORCE_UPDATE = "force_update";

	public const string ADS_WATCHED_REQUIRED_SHOW_IAP_PACK = "ads_watched_required_show_iap_package";

	private FirebaseRemoteData data;

	private NormalEventInvoker getRemoteConfigInvoker;

	public bool IsForceUpdate { get; private set; }

	public bool IsFetchDataComplete { get; set; }

	public bool IsInitialized { get; set; }

	public bool IsWaitingForCheckDependency { get; set; }

	public FirebaseRemoteData Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void OnInit()
	{
	}

	[AsyncStateMachine(typeof(_003CAsyncInit_003Ed__42))]
	public void AsyncInit()
	{
	}

	private void OnDestroy()
	{
	}

	public void InitRemoteConfig()
	{
	}

	private Task FetchDataAsync()
	{
		return null;
	}

	private void FetchComplete(Task fetchTask)
	{
	}

	private int FirebaseToInt(string key)
	{
		return 0;
	}

	private string FirebaseToString(string key)
	{
		return null;
	}

	private bool FirebaseToBool(string key)
	{
		return false;
	}

	public void DisplayData()
	{
	}

	public void SolveForceUpdateData()
	{
	}
}
