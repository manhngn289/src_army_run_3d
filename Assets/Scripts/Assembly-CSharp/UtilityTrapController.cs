using System.Collections.Generic;
using UnityEngine;

public class UtilityTrapController : MonoBehaviour, IChangeBattleCamActivePlayerAttackManager
{
	private List<IChangeCamBattle> changeCamBattleObjects;

	private List<IActivePlayerAttack> activeAttackPlayerObjects;

	public void SetupAllTrapUtility()
	{
	}

	private void Update()
	{
	}

	private bool IsHasChangeCamInRangePlayer(float distanceCheck)
	{
		return false;
	}

	private bool IsHasActiveAttackPlayerInRange(float distanceCheck)
	{
		return false;
	}

	public void RemoveIChangeBattleCam(IChangeCamBattle removeObject)
	{
	}

	public void RemoveIActiveAttackPlayer(IActivePlayerAttack removeObject)
	{
	}
}
