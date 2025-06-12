using Aluta;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonClick : MonoBehaviour
{
	private enum ClickType
	{
		Normal = 0,
		Upgrade = 1
	}

	[SerializeField]
	[ReadOnly]
	private Button selfBtn;

	[SerializeField]
	private ClickType clickType;

	private void OnValidate()
	{
	}

	private void Start()
	{
	}

	public void ClickSound()
	{
	}
}
