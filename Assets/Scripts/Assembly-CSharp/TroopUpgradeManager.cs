using System.Collections.Generic;
using Aluta;
using UnityEngine;

public class TroopUpgradeManager : MonoBehaviour
{
	public const int MAX_UPGRADE_TROOPS = 120;

	[SerializeField]
	[ReadOnly]
	private bool initialized;

	[SerializeField]
	[ReadOnly]
	private bool isShowTutoReuse;

	[SerializeField]
	private List<UIUpgradeItem> upgradeItems;

	[SerializeField]
	private ParticleSystem upgradeFX;

	[SerializeField]
	private GameObject blockInteractUpgrade;

	public void SetData()
	{
	}

	public void RefreshUI()
	{
	}

	public void EnableUpgradeInteract()
	{
	}

	public void DisableUpgradeInteract()
	{
	}
}
