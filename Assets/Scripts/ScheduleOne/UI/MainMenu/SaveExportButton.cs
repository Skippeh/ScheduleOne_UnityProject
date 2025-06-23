namespace ScheduleOne.UI.MainMenu
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.UI.Button))]
	public class SaveExportButton : global::UnityEngine.MonoBehaviour
	{
		public int SaveSlotIndex;

		private void Awake()
		{
		}

		private void Clicked()
		{
		}

		public static string ShowSaveFileDialog(string fileName)
		{
			return null;
		}

		public static void ZipSaveFolder(string sourceFolderPath, string destinationZipPath)
		{
		}
	}
}
