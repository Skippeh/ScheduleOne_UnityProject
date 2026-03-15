namespace ScheduleOne
{
	public class UISwitchInputModeDetector : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Events.UnityEvent OnInputModeChanged;

		public global::UnityEngine.Events.UnityEvent OnInputModeChangedToController;

		public global::UnityEngine.Events.UnityEvent OnInputModeChangedToMouse;

		private void Start()
		{
		}

		private void OnControlsChanged(global::ScheduleOne.GameInput.InputDeviceType type)
		{
		}

		private void SwitchMode(global::ScheduleOne.GameInput.InputDeviceType type)
		{
		}
	}
}
