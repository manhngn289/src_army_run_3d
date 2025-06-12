using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HiGame;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Security;

public class IAPManager : Singleton<IAPManager>, IDetailedStoreListener, IStoreListener
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAsyncInit_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public IAPManager _003C_003E4__this;

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

	private IStoreController m_StoreController;

	private IGooglePlayStoreExtensions m_GooglePlayStoreExtensions;

	private IAppleExtensions m_AppleExtensions;

	private Action<bool> _callbackFunction;

	private CrossPlatformValidator validator;

	public readonly List<string> _consumablePurchaseIds;

	public readonly List<string> _nonConsumablePurchaseIds;

	private void Start()
	{
	}

	protected override void OnInit()
	{
	}

	[AsyncStateMachine(typeof(_003CAsyncInit_003Ed__9))]
	public void AsyncInit()
	{
	}

	private void InitializePurchasing()
	{
	}

	public void Restore()
	{
	}

	public void Purchase(int shopItemId, Action<bool> callbackFunction)
	{
	}

	public void Purchase(string purchaseId, Action<bool> callbackFunction)
	{
	}

	public string GetPriceString(int itemId)
	{
		return null;
	}

	public decimal GetLocalPrice(int itemId)
	{
		return default(decimal);
	}

	private Product GetProduct(int shopItemId)
	{
		return null;
	}

	public void OnInitializeFailed(InitializationFailureReason error, string message = null)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
	{
	}

	public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
	{
		return default(PurchaseProcessingResult);
	}

	private int GetReceiptQuantity(string receipt)
	{
		return 0;
	}
}
