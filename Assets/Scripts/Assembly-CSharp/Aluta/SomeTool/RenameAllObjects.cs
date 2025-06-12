using UnityEngine;

namespace Aluta.SomeTool
{
	public class RenameAllObjects : MonoBehaviour
	{
		[SerializeField]
		private NameAffixType nameAffixType;

		[SerializeField]
		private int charChangeAmount;

		[SerializeField]
		private string replaceString;

		[SerializeField]
		private GameObject[] objectsToRename;

		[ContextMenu("ChangeNameAffix")]
		public void ChangeNameAffix()
		{
		}
	}
}
