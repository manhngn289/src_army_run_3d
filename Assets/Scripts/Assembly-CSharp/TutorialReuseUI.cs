using Aluta;
using UnityEngine;
using UnityEngine.UI;

public class TutorialReuseUI : MonoBehaviour
{
	[SerializeField]
	[ReadOnly]
	private bool isInited;

	[SerializeField]
	[ReadOnly]
	private GameObject tutoHandInited;

	[SerializeField]
	private GameObject tutoHandPrefab;

	[SerializeField]
	private Button selfBtn;

	public void ActiveTuto()
	{
	}

	public void DeactiveTuto()
	{
	}

	public void DoneTuto()
	{
	}
}
