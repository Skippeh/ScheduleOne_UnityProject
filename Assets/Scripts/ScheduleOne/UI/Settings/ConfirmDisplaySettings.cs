namespace ScheduleOne.UI.Settings
{
	public class ConfirmDisplaySettings : global::UnityEngine.MonoBehaviour
	{
		public const float RevertTime = 15f;

		public global::TMPro.TextMeshProUGUI SubtitleLabel;

		private float timeUntilRevert;

		private global::ScheduleOne.DevUtilities.DisplaySettings oldSettings;

		private global::ScheduleOne.DevUtilities.DisplaySettings newSettings;

		public bool IsOpen => false;

		public void Awake()
		{
		}

		public void Open(global::ScheduleOne.DevUtilities.DisplaySettings _oldSettings, global::ScheduleOne.DevUtilities.DisplaySettings _newSettings)
		{
		}

		public void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void Update()
		{
		}

		public void Close(bool revert)
		{
		}
	}
}
