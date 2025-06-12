using UnityEngine;

namespace Aluta
{
	public class Singleton<T> : MonoBehaviour where T : Component
	{
		private static T _instance;

		public static T I
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}
	}
}
