using System;
using UnityEngine;

namespace MagicExcel
{
	[Serializable]
	public struct EncryptedDouble : IEncryptedType
	{
		private const long KEY = 2362831L;

		[SerializeField]
		private long encryptedValue;

		public EncryptedDouble(double value)
		{
			encryptedValue = 0L;
		}

		public object Decrypt()
		{
			return null;
		}

		public static double Decrypt(long encryptedValue)
		{
			return 0.0;
		}

		public static implicit operator double(EncryptedDouble value)
		{
			return 0.0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
