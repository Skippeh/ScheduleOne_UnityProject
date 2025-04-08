namespace ScheduleOne.DevUtilities
{
	[global::System.Serializable]
	public class InputSettings
	{
		public enum EActionMode
		{
			Press = 0,
			Hold = 1
		}

		public float MouseSensitivity;

		public bool InvertMouse;

		public global::ScheduleOne.DevUtilities.InputSettings.EActionMode SprintMode;

		public string BindingOverrides;
	}
}
