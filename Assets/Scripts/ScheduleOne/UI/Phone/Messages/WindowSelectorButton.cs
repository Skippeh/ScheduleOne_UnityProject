using ScheduleOne.Economy;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	public class WindowSelectorButton : MonoBehaviour
	{
		public const float SELECTION_INDICATOR_SCALE = 1.1f;

		public const float INDICATOR_LERP_TIME = 0.075f;

		public UnityEvent OnSelected;

		public EDealWindow WindowType;

		[Header("References")]
		public Button Button;

		public GameObject InactiveOverlay;

		public RectTransform HoverIndicator;

		private Coroutine hoverRoutine;

		private void Awake()
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		public void HoverStart()
		{
		}

		public void HoverEnd()
		{
		}

		public void Clicked()
		{
		}

		public void SetHoverIndicator(bool shown)
		{
		}
	}
}
