namespace ScheduleOne.UI.Phone.Messages
{
	public class WindowSelectorButton : global::UnityEngine.MonoBehaviour
	{
		public const float SELECTION_INDICATOR_SCALE = 1.1f;

		public const float INDICATOR_LERP_TIME = 0.075f;

		public global::UnityEngine.Events.UnityEvent OnSelected;

		public global::ScheduleOne.Economy.EDealWindow WindowType;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Button Button;

		public global::UnityEngine.GameObject InactiveOverlay;

		public global::UnityEngine.RectTransform HoverIndicator;

		private global::UnityEngine.Coroutine hoverRoutine;

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
