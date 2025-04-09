using ScheduleOne.ExtendedComponents;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.MainMenu
{
	public class SetupScreen : MainMenuScreen
	{
		public const string DEFAULT_SAVE_PATH = "DefaultSave";

		[Header("References")]
		public GameInputField InputField;

		public Button StartButton;

		public RectTransform SkipIntroContainer;

		public Toggle SkipIntroToggle;

		public RectTransform NotHostWarning;

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
