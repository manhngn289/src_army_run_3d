using Aluta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TutorialStepCheckerUI : MonoBehaviour
{
	[SerializeField]
	[ReadOnly]
	private bool isDone;

	public TutorialID tutorialID;

	[SerializeField]
	private bool isForceTuto;

	[SerializeField]
	private Transform initParent;

	[SerializeField]
	private GameObject tutoHandPrefab;

	[SerializeField]
	private Button stepBtn;

	[SerializeField]
	private bool isDelay;

	[SerializeField]
	private float delayTime;

	[SerializeField]
	private bool useSlowTime;

	[SerializeField]
	private float slowTimeValue;

	[SerializeField]
	private float slowDuration;

	[SerializeField]
	private bool tutorialNotActiveInScene;

	[SerializeField]
	private bool isAutoCompleteOnClick;

	[SerializeField]
	private bool logEventAnalytics;

	[SerializeField]
	private bool autoCompleteHalfStep;

	public UnityEvent onTutorialNotActiveInScene;

	private GameObject tutorialHandGO;

	public bool IsDone => false;

	private void Start()
	{
	}

	public void InvokeStep()
	{
	}

	public void DoneHalfStep()
	{
	}

	public void DoneStep()
	{
	}
}
