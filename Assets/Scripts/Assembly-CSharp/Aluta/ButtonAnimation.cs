using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Aluta
{
	public class ButtonAnimation : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[SerializeField]
		private ButtonAnimationSetting setting;

		[SerializeField]
		private Transform scaleGraphic;

		private Button selfBtn;

		private Vector3 initScale;

		private Transform targetScaleTR;

		private void Awake()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}
	}
}
