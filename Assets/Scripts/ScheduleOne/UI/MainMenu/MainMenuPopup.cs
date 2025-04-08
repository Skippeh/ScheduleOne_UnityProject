namespace ScheduleOne.UI.MainMenu
{
	public class MainMenuPopup : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.MainMenu.MainMenuPopup>
	{
		public class Data
		{
			public string Title;

			public string Description;

			public bool IsBad;

			public Data(string title, string description, bool isBad)
			{
			}
		}

		public global::ScheduleOne.UI.MainMenu.MainMenuScreen Screen;

		public global::TMPro.TextMeshProUGUI Title;

		public global::TMPro.TextMeshProUGUI Description;

		public void Open(global::ScheduleOne.UI.MainMenu.MainMenuPopup.Data data)
		{
		}

		public void Open(string title, string description, bool isBad)
		{
		}
	}
}
