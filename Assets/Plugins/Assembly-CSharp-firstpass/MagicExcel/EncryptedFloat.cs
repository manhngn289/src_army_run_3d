using System;
using UnityEngine;

namespace MagicExcel
{
	[Serializable]
	public struct EncryptedFloat : IEncryptedType
	{
		private const int KEY = 234171;

		[SerializeField]
		private int encryptedValue;

		public EncryptedFloat(float value)
		{
			encryptedValue = 0;
		}

		public object Decrypt()
		{
			return null;
		}

		public static float Decrypt(int encryptedValue)
		{
			return 0f;
		}

		public static implicit operator float(EncryptedFloat value)
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
