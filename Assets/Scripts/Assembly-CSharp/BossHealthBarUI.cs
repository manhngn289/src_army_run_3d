using Everest.CustomEditor;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBarUI : MonoBehaviour
{
	[DisplayAsString]
	private UnitEnemyController currentBoss;

	[SerializeField]
	private Image healthBarFillImg;

	private float maxHP;

	[SerializeField]
	private CanvasGroup healthBarAlpha;

	public void SetData(UnitEnemyController bossUnitController)
	{
	}

	private void UpdateHealthBar()
	{
	}

	public void Update()
	{
	}

	public void ShowBossHealthBar()
	{
	}

	public void HideBossHealthBar(AttackerType attackerType)
	{
	}
}
