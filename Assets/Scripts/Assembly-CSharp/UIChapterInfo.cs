using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIChapterInfo : MonoBehaviour
{
	[SerializeField]
	[FormerlySerializedAs("chapterName")]
	private TMP_Text levelTxt;

	[SerializeField]
	private List<UIChapterLevelElement> uIChapterLevelElements;

	[SerializeField]
	private Sprite[] chapterPreviewSprites;

	[SerializeField]
	private Image chapterNextPreview;

	public void SetInfo(LevelController currentLevelGo)
	{
	}
}
