using Aluta;
using UnityEngine;
using UnityEngine.UI;

public class UIActiveSkill : MonoBehaviour
{
	[SerializeField]
	[ReadOnly]
	private bool isFree;

	[SerializeField]
	[ReadOnly]
	private bool isForceActive;

	[SerializeField]
	private ActiveSkillType skillType;

	[SerializeField]
	private GameObject adsImgGO;

	[SerializeField]
	private GameObject adsTicketGo;

	[SerializeField]
	private Image[] cooldownImg;

	[SerializeField]
	private Button activeBtn;

	[SerializeField]
	private float cooldownTime;

	public void SetData(bool isFree, bool isForceActive = false)
	{
	}

	public void ActiveSkillBtnClick()
	{
	}

	private void ActiveSkill()
	{
	}

	private void ActiveSkillWithAds()
	{
	}

	private void CooldownSkill()
	{
	}
}
