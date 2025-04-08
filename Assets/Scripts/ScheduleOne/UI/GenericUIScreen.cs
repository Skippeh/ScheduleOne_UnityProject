namespace ScheduleOne.UI
{
	public class GenericUIScreen : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public string Name;

		public bool UseExitActions;

		public int ExitActionPriority;

		public bool CanExitWithRightClick;

		public bool ReenableControlsOnClose;

		public bool ReenableInventoryOnClose;

		public bool ReenableEquippingOnClose;

		public global::UnityEngine.Events.UnityEvent onOpen;

		public global::UnityEngine.Events.UnityEvent onClose;

		public bool IsOpen { get; private set; }

		private void Awake()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}
	}
}
