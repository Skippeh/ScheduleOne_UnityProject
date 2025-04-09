using ScheduleOne.DevUtilities;
using TMPro;

namespace ScheduleOne.UI.MainMenu
{
	public class MainMenuPopup : Singleton<MainMenuPopup>
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

		public MainMenuScreen Screen;

		public TextMeshProUGUI Title;

		public TextMeshProUGUI Description;

		public void Open(Data data)
		{
		}

		public void Open(string title, string description, bool isBad)
		{
		}
	}
}
