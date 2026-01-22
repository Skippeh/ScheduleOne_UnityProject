namespace ScheduleOne.Persistence
{
	public class SaveManager : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.Persistence.SaveManager>
	{
		public const string MAIN_SCENE_NAME = "Main";

		public const string MENU_SCENE_NAME = "Menu";

		public const string TUTORIAL_SCENE_NAME = "Tutorial";

		public const int SAVES_PER_FRAME = 15;

		public const string SAVE_FILE_EXTENSION = ".json";

		public const int SAVE_SLOT_COUNT = 5;

		public const string SAVE_GAME_PREFIX = "SaveGame_";

		public const bool DEBUG = false;

		public const bool PRETTY_PRINT = true;

		public static bool SaveError;

		public global::System.Collections.Generic.List<global::ScheduleOne.Persistence.ISaveable> Saveables;

		public global::System.Collections.Generic.List<global::ScheduleOne.Persistence.IBaseSaveable> BaseSaveables;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<string> ApprovedBaseLevelPaths;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Persistence.ISaveable> CompletedSaveables;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Persistence.SaveRequest> QueuedSaveRequests;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform WriteIssueDisplay;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent onSaveStart;

		public global::UnityEngine.Events.UnityEvent onSaveComplete;

		private bool saveFolderInitialized;

		public bool AccessPermissionIssueDetected { get; protected set; }

		public bool IsSaving { get; protected set; }

		public float SecondsSinceLastSave { get; protected set; }

		public string PlayersSavePath { get; protected set; }

		public string IndividualSavesContainerPath { get; protected set; }

		public string BackupFolderPath => null;

		public string SaveName { get; protected set; }

		public static void ReportSaveError()
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void CheckSaveFolderInitialized()
		{
		}

		public static bool HasWritePermissionOnDir(string path)
		{
			return false;
		}

		private void Update()
		{
		}

		public void Save()
		{
		}

		public void Save(string saveFolderPath)
		{
		}

		private void ClearBaseLevelOutdatedSaves(string saveFolderPath)
		{
		}

		public void CompleteSaveable(global::ScheduleOne.Persistence.ISaveable saveable)
		{
		}

		public void ClearCompletedSaveable(global::ScheduleOne.Persistence.ISaveable saveable)
		{
		}

		public void CreateSaveBackup(global::ScheduleOne.Persistence.SaveInfo saveInfo)
		{
		}

		public void RegisterSaveable(global::ScheduleOne.Persistence.ISaveable saveable)
		{
		}

		public void QueueSaveRequest(global::ScheduleOne.Persistence.SaveRequest request)
		{
		}

		public void DequeueSaveRequest(global::ScheduleOne.Persistence.SaveRequest request)
		{
		}

		public static string StripExtensions(string filePath)
		{
			return null;
		}

		public static string MakeFileSafe(string fileName)
		{
			return null;
		}

		public static float GetVersionNumber(string version)
		{
			return 0f;
		}

		private void Clean()
		{
		}

		public void DisablePlayTutorial(global::ScheduleOne.Persistence.SaveInfo info)
		{
		}

		public static string SanitizeFileName(string fileName)
		{
			return null;
		}
	}
}
