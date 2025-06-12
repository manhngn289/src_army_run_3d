using System.Collections.Generic;
using UnityEngine;

namespace Aluta.SomeTool
{
	public class ChangeMatAllObjects : MonoBehaviour
	{
		[SerializeField]
		private Material matChange;

		[SerializeField]
		private List<Transform> allParentChangeMat;

		[ContextMenu("ChangeMatAllObjects")]
		public void ChangeAllMatChildren()
		{
		}
	}
}
