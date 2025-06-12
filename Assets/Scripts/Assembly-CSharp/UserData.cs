using System;
using System.Collections.Generic;
using Everest;
using Everest.CustomEditor;
using UnityEngine;

[Serializable]
public class UserData : BaseData<UserData>
{
	public const int UNLOCK_UPGRADE_LEVEL = 1;

	public const int UNLOCK_LEVEL_BUFF = 2;

	public const int UNLOCK_TALENT_LEVEL = 3;

	public const int UNLOCK_ACTIVE_SKILL = 3;

	public const int UNLOCK_SKIN = 4;

	public const int UNLOCK_NOADS_PACK = 5;

	public const int UNLOCK_STARTER_PACK = 7;

	public const int CURRENCY_DAILY_REWARD_LIMIT = 3;

	[DisplayAsDateTime]
	public long newDayTime;

	[DisplayAsDateTime]
	public long firstOpenTime;

	public int languageID;

	public int level;

	public int coin;

	public int elixir;

	public int adsTicket;

	public bool isUnlockTalent;

	public bool isFreeReRollLevelBuff;

	public bool isFreeActiveSkill;

	public bool useFreeAdsFirstLevelBuffEpic;

	public bool removeAds;

	public bool starterPack;

	public bool isSetMaxLevelFirstTime;

	public int skinCurrentUse;

	public List<int> skinUnlocked;

	public int skinUnlockInProgress;

	public int currentProgressUnlockSkin;

	[SerializeField]
	private List<int> troopUpgradeLevels;

	[SerializeField]
	private List<TalentData> talentLevelByType;

	public int talentUpgradeSequenceCount;

	public bool tutoFirstLevel;

	public int tutorialID;

	public int goldDailyReward;

	public int elixirDailyReward;

	public List<int> SkinUnlocked => null;

	public List<int> TroopUpgradeLevels => null;

	public List<TalentData> TalentLevelByType => null;

	public void NewDay()
	{
	}
}
