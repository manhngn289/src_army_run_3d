using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace HG.Rate
{
	public class ButtonScale : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler, IPointerUpHandler, IPointerExitHandler, IPointerClickHandler
	{
		[SerializeField]
		[Header("Reference")]
		private Transform _tfTarget;

		[SerializeField]
		[Header("Config")]
		private Vector2 _scaleValue;

		[SerializeField]
		[Min(0.1f)]
		private float _scaleSpeed;

		[SerializeField]
		private bool _playSound;

		private bool _isDown;

		private Tween _tween;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void ScaleUp()
		{
		}

		private void ScaleDown()
		{
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
		{
		}

		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
		{
		}

		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
		}

		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
