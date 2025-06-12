using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CheatUI : MonoBehaviour
{
	[SerializeField]
	private Button loadLevelBtn;

	[SerializeField]
	private Button add1MCoinBtn;

	[SerializeField]
	private Button add1MElixirBtn;

	[SerializeField]
	private Button hideUIBtn;

	[SerializeField]
	private Button showUIBtn;

	[SerializeField]
	private Button changeLevelEvolvedBtn;

	[SerializeField]
	private UIMainMenuManager uIMainMenuManager;

	[SerializeField]
	[FormerlySerializedAs("inputField")]
	private TMP_InputField levelInputField;

	[FormerlySerializedAs("inputField")]
	[SerializeField]
	private TMP_InputField levelEvolveInputField;

	[SerializeField]
	private GameObject cheatUI;

	private void Start()
	{
	}
}
