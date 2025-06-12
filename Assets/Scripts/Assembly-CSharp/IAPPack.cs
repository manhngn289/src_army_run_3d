using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Purchasing;

public class IAPPack
{
	[CompilerGenerated]
	private sealed class _003CGetAll_003Ed__3 : IEnumerable<IAPPack>, IEnumerable, IEnumerator<IAPPack>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private IAPPack _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerator _003C_003E7__wrap1;

		IAPPack IEnumerator<IAPPack>.Current
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
		public _003CGetAll_003Ed__3(int _003C_003E1__state)
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

		[DebuggerHidden]
		IEnumerator<IAPPack> IEnumerable<IAPPack>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public ProductDefinition productDefinition;

	public string price;

	public Action restoreAction;

	[IteratorStateMachine(typeof(_003CGetAll_003Ed__3))]
	public static IEnumerable<IAPPack> GetAll()
	{
		return null;
	}

	public static IAPPack Get(IAPProductId id)
	{
		return null;
	}

	public static string GetId(IAPProductId id)
	{
		return null;
	}
}
