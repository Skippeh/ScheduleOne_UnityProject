namespace ScheduleOne
{
	public static class OnScreenKeyboard
	{
		private static uint s_charLimit;

		private static global::System.Action<string> s_onSubmit;

		private static global::System.Action s_onCancel;

		private static global::Steamworks.Callback<global::Steamworks.GamepadTextInputDismissed_t> s_onGamepadTextInputDismissed;

		public static void Show(global::System.Action<string> onSubmit, global::System.Action onCancel = null, string description = "", uint charMax = 32u, string defaultText = "")
		{
		}

		private static void OnGamepadTextInputDismissed(global::Steamworks.GamepadTextInputDismissed_t param)
		{
		}
	}
}
