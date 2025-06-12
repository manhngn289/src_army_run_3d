using System;
using System.Collections.Generic;

[Serializable]
public class TutorialData
{
	public string tutoName;

	public int levelRequired;

	public TutorialID tutorialID;

	public int tutorialTotalStep;

	public bool autoInvoke;

	public List<TutorialStepCheckerUI> tutorialStepCheckerUIs;

	public void AddStep(TutorialStepCheckerUI tutorialStepCheckerUI)
	{
	}

	public void AddStep(List<TutorialStepCheckerUI> tutorialStepCheckerUIs)
	{
	}
}
