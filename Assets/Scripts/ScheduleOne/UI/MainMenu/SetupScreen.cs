namespace ScheduleOne.UI.MainMenu
{
	public class SetupScreen : global::ScheduleOne.UI.MainMenu.MainMenuScreen
	{
		public const string DEFAULT_SAVE_PATH = "DefaultSave";

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.ExtendedComponents.GameInputField InputField;

		public global::UnityEngine.UI.Button StartButton;

		public global::UnityEngine.RectTransform SkipIntroContainer;

		public global::UnityEngine.UI.Toggle SkipIntroToggle;

		public global::UnityEngine.RectTransform NotHostWarning;

		private int slotIndex;

		protected virtual void Start()
		{
		}

		public void Initialize(int index)
		{
		}

		private void Update()
		{
		}

		public void StartGame()
		{
		}

		private bool IsInputValid()
		{
			return false;
		}

		private void ClearFolderContents(string folderPath)
		{
		}

		private void CopyDefaultSaveToFolder(string folderPath)
		{
		}

		private static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
		}
	}
}
