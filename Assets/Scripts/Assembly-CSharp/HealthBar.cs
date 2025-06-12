using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public Image healthBarRealtime;

	public Image healthBarSlow;

	public Transform targetToFollow;

	private UnitHealth unitOfHealthBar;

	[SerializeField]
	private float timeFade;

	[SerializeField]
	private CanvasGroup alpha;

	[SerializeField]
	private Color slowColor;

	[SerializeField]
	private Color immediateColor;

	[SerializeField]
	private Color fadeOffColor;

	private float currentTimeOn;

	public void Init(UnitHealth unitHealth)
	{
	}

	private void Update()
	{
	}

	private void FadeOffHealthBar()
	{
	}

	public void UpdateHealth(bool isImmediately = false)
	{
	}

	private void OnDisable()
	{
	}

	public void OnDespawned()
	{
	}
}
