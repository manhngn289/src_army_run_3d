using System.Collections.Generic;
using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class TutorialUI : Singleton<TutorialUI>
{
	public TutorialData currentTutorialInvoke;

	public List<TutorialData> tutoDatas;

	[SerializeField]
	private GameObject tutoShadowGO;

	[SerializeField]
	private GameObject firstLevelTuto;

	public TutorialStepCheckerUI currentTutorialStep;

	[Button(null)]
	public void CheckInvokeTutorial()
	{
	}

	public void ForceInvokeTutoByID(TutorialID tutoIDInvoke)
	{
	}

	public void ShowFirstLevelTuto()
	{
	}

	public void HideFirstLevelTuto()
	{
	}

	public void ShowTutoShadow()
	{
	}

	public void HideTutoShadow()
	{
	}

	private void InvokeTutorial(TutorialData tutorialData)
	{
	}
}
