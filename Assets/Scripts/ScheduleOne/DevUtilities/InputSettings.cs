using System;

namespace ScheduleOne.DevUtilities
{
	[Serializable]
	public class InputSettings
	{
		public enum EActionMode
		{
			Press = 0,
			Hold = 1
		}

		public float MouseSensitivity;

		public bool InvertMouse;

		public EActionMode SprintMode;

		public string BindingOverrides;
	}
}
