namespace ScheduleOne
{
	public class UITab : global::ScheduleOne.UIPanel, global::ScheduleOne.INonNavigablePanel
	{
		public enum CycleInputActionType
		{
			Primary = 0,
			Secondary = 1
		}

		public enum CycleDirection
		{
			Horizontal = 0,
			Vertical = 1
		}

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Set to true to looping of cycling behavior between the first and last selectables index.")]
		private bool allowLooping;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("The InputActions for cycling behavior.")]
		private global::ScheduleOne.UITab.CycleInputActionType cycleInputActionType;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("The InputActions for cycling behavior.")]
		private global::ScheduleOne.UITab.CycleDirection cycleDirection;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("UI display for cycle left")]
		private global::TMPro.TextMeshProUGUI cycleLeftVisual;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("UI display for cycle right")]
		private global::TMPro.TextMeshProUGUI cycleRightVisual;

		private float cycleTabTimer;

		private bool wasCycleTabPressedLastFrame;

		protected override void EarlyUpdate()
		{
		}

		private float GetCycleTabInputValue()
		{
			return 0f;
		}

		private void CycleTab(float navDir, float delay, float speed)
		{
		}

		private bool Navigate(float navDir)
		{
			return false;
		}

		private bool Navigate2(float navDir)
		{
			return false;
		}

		protected override void HandleInputDeviceChanged(global::ScheduleOne.GameInput.InputDeviceType type)
		{
		}
	}
}
