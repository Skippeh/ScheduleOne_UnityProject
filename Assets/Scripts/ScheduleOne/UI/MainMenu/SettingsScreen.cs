namespace ScheduleOne.UI.MainMenu
{
	public class SettingsScreen : global::ScheduleOne.UI.MainMenu.MainMenuScreen
	{
		[global::System.Serializable]
		public class SettingsCategory
		{
			public global::UnityEngine.UI.Button Button;

			public global::UnityEngine.GameObject Panel;
		}

		public global::ScheduleOne.UI.MainMenu.SettingsScreen.SettingsCategory[] Categories;

		public global::UnityEngine.UI.Button ApplyDisplayButton;

		public global::ScheduleOne.UI.Settings.ConfirmDisplaySettings ConfirmDisplaySettings;

		protected override void Awake()
		{
		}

		protected void Start()
		{
		}

		public void ShowCategory(int index)
		{
		}

		public void DisplayChanged()
		{
		}

		private void ApplyDisplaySettings()
		{
		}
	}
}
