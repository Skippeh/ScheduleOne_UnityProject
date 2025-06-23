namespace ScheduleOne.UI.MainMenu
{
	public class ImportScreen : global::ScheduleOne.UI.MainMenu.MainMenuScreen
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject MainContainer;

		public global::UnityEngine.GameObject FailContainer;

		public global::UnityEngine.UI.Button ConfirmButton;

		public global::TMPro.TextMeshProUGUI OrganisationNameLabel;

		public global::TMPro.TextMeshProUGUI NetworthLabel;

		public global::TMPro.TextMeshProUGUI VersionLabel;

		public global::TMPro.TextMeshProUGUI WarningLabel;

		private int slotToOverwrite;

		private global::ScheduleOne.Persistence.SaveInfo saveInfo;

		public void Initialize(int _slotToOverwrite, global::ScheduleOne.UI.MainMenu.MainMenuScreen previousScreen)
		{
		}

		public void Cancel()
		{
		}

		public void Confirm()
		{
		}

		private static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
		}
	}
}
