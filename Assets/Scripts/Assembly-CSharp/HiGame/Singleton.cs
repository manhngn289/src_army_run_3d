using UnityEngine;

namespace HiGame
{
	public class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		private static bool m_ShuttingDown;

		private static object m_Lock;

		private static T m_Instance;

		public static T Instance => null;

		public static bool HasInstance => false;

		protected virtual void Awake()
		{
		}

		protected virtual void OnInit()
		{
		}
	}
}
