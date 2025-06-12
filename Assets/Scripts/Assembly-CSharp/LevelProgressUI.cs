using Everest.CustomEditor;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgressUI : MonoBehaviour
{
	private const float OFF_SET_PLAYER_ICON = 5f;

	private const float OFF_SET_PLAYER_BOX = 0.3f;

	[DisplayAsString]
	private LevelController currentLevel;

	[DisplayAsString]
	private float distancePlayerToFinishInit;

	[SerializeField]
	private Image levelFinishTypeIconImg;

	[SerializeField]
	private Image levelProgressFillImg;

	[SerializeField]
	private RectTransform playerIconRTR;

	[SerializeField]
	private RectTransform levelProgressBG;

	[SerializeField]
	private Sprite[] levelFinishTypeIconSprites;

	private Transform playerTR;

	private Vector3 playerAnchoredPos;

	[SerializeField]
	private CanvasGroup progressAlpha;

	private float BGWidth => 0f;

	private float CurrentDistancePlayerToFinish => 0f;

	private float PlayerProgress => 0f;

	public void SetData(LevelController levelController)
	{
	}

	private void Update()
	{
	}

	public void UpdatePlayerIconPos()
	{
	}

	public void ShowLevelProgress()
	{
	}

	public void HideLevelProgress(bool immediately = false)
	{
	}

	private void OnDisable()
	{
	}
}
