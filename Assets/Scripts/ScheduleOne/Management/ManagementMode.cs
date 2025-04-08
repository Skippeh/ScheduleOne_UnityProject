namespace ScheduleOne.Management
{
	public class ManagementMode : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Management.ManagementMode>
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.Input.InputPrompt ManagementModeInputPrompt;

		[global::UnityEngine.Header("UI References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.Events.UnityEvent OnEnterManagementMode;

		public global::UnityEngine.Events.UnityEvent onExitManagementMode;

		public global::ScheduleOne.Property.Property CurrentProperty { get; private set; }

		public bool isActive => false;

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateInput()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exitAction)
		{
		}

		public void EnterManagementMode(global::ScheduleOne.Property.Property property)
		{
		}

		public void ExitManagementMode()
		{
		}

		public static bool CanEnterManagementMode()
		{
			return false;
		}

		public static bool CanExitManagementMode()
		{
			return false;
		}
	}
}
