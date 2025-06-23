namespace ScheduleOne.UI.MainMenu
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.UI.Button))]
	public class SaveImportButton : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.UI.MainMenu.ImportScreen ImportScreen;

		public global::ScheduleOne.UI.MainMenu.MainMenuScreen ParentScreen;

		public int SaveSlotIndex;

		public static string TempImportPath => null;

		private void Awake()
		{
		}

		private void Clicked()
		{
		}

		public static void UnzipSaveFile(string zipFilePath, string destinationFolderPath)
		{
		}

		public static string ShowOpenFileDialog()
		{
			return null;
		}
	}
}
