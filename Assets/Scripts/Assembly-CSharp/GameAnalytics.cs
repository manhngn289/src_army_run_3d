public static class GameAnalytics
{
	private const string RETENTION_TYPE = "retent_type";

	private const string DAY_PLAYED = "days_played";

	private const string LEVEL = "level";

	private const string LEVEL_START = "level_start";

	private const string LEVEL_COMPLETE = "level_complete";

	private const string LEVEL_FAILED = "level_fail";

	private const string TIME_PLAYED = "timeplayed";

	private const string PLAYER_DEAD_POS = "pdpos";

	private const string DEAD_BY = "dby";

	private const string FAIL_COUNT = "failcount";

	public static string AllyDeadBy;

	private const int OFFSET_REAL_LEVEL = 1;

	private static void SetUserProp(string prop, string value)
	{
	}

	public static void SetMaxLevel(string level)
	{
	}

	public static void LogRetentionType(int value)
	{
	}

	public static void LogDayPlayed()
	{
	}

	public static void LogTutorialDone(TutorialID tutorialID)
	{
	}

	public static void LogLevelStart(int level)
	{
	}

	public static void LogLevelComplete(int level, float timePlayed)
	{
	}

	private static string LevelFailCount(int level)
	{
		return null;
	}

	public static void LogLevelFail(int level, float timePlayed, float playerPos)
	{
	}

	private static void SaveFailCount(int level)
	{
	}
}
