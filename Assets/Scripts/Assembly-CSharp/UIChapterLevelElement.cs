using UnityEngine;
using UnityEngine.UI;

public class UIChapterLevelElement : MonoBehaviour
{
	[SerializeField]
	private Image levelStatusImg;

	[SerializeField]
	private Sprite[] levelStatusSprites;

	[SerializeField]
	private Color blinkColor;

	[SerializeField]
	private float blinkTime;

	public void SetLevelStatus(int status)
	{
	}
}
