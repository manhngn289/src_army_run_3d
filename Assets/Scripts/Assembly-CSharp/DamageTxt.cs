using Everest.CustomEditor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DamageTxt : MonoBehaviour
{
	public CanvasGroup dmgTxtAlpha;

	public TextMeshProUGUI dmgTxt;

	[SerializeField]
	private GameObject dmgImgsGO;

	[SerializeField]
	private Image[] damageImage;

	[Button(null)]
	private void Test()
	{
	}

	public void Init(float damage, DamageType dmgType)
	{
	}
}
