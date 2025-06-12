using System;
using UnityEngine;

namespace MagicExcel
{
	[Serializable]
	public struct EncryptedInt : IEncryptedType
	{
		private const int KEY = 45213971;

		[SerializeField]
		private int encryptedValue;

		public EncryptedInt(int value)
		{
			encryptedValue = 0;
		}

		public object Decrypt()
		{
			return null;
		}

		public static int Decrypt(int encryptedValue)
		{
			return 0;
		}

		public static implicit operator int(EncryptedInt value)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
