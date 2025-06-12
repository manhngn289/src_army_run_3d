using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class EnemyStatMultiplyByLevelSheet
{
	public int level;

	public float atkMulti;

	public float hpMulti;

	private static Dictionary<int, EnemyStatMultiplyByLevelSheet> dictionary;

	public static EnemyStatMultiplyByLevelSheet FirstValue { get; private set; }

	public static EnemyStatMultiplyByLevelSheet LastValue { get; private set; }

	public static EnemyStatMultiplyByLevelSheet Get(int level, DefaultReturnKind defaultReturnKind = DefaultReturnKind.Exception)
	{
		return null;
	}

	public static Dictionary<int, EnemyStatMultiplyByLevelSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, EnemyStatMultiplyByLevelSheet> dic)
	{
	}
}
