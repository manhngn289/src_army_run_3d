using UnityEngine;

namespace Aluta
{
	public class FollowAPoint : MonoBehaviour
	{
		public Transform pointFollow;

		[SerializeField]
		private FollowType followType;

		[SerializeField]
		private Vector3 followAxis;

		[SerializeField]
		private Vector3 offset;

		private Vector3 tempPos;

		private void Update()
		{
		}
	}
}
