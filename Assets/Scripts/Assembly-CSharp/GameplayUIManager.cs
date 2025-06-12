using Aluta;
using Everest.CustomEditor;
using UnityEngine;

public class GameplayUIManager : Singleton<GameplayUIManager>
{
	[SerializeField]
	private GameObject pauseBtnGO;

	[SerializeField]
	private CanvasGroup listActiveSkillTR;

	[SerializeField]
	private UIActiveSkill[] activeSkillBtns;

	[SerializeField]
	[Header("Tutorial ActiveSkill")]
	private ActiveSkillType skillTutorial;

	public void ShowSkillActiveTuto()
	{
	}

	public void ShowActiveSkillDefault()
	{
	}

	public void ShowActiveSkill(ActiveSkillType skillType, bool isFree, bool isForeceActive)
	{
	}

	[Button(null)]
	public void HideActiveSkill()
	{
	}

	private void ActiveSkillBtn(ActiveSkillType skillType, bool isFree, bool isForceAtive)
	{
	}

	public void ShowPauseBtn()
	{
	}

	private void HidePauseBtn()
	{
	}

	public void HideGameplayUIOnHome()
	{
	}
}
