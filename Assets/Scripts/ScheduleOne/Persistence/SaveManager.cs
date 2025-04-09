using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	public class SaveManager : PersistentSingleton<SaveManager>
	{
		public const string MAIN_SCENE_NAME = "Main";

		public const string MENU_SCENE_NAME = "Menu";

		public const string TUTORIAL_SCENE_NAME = "Tutorial";

		public const int SAVES_PER_FRAME = 10;

		public const string SAVE_FILE_EXTENSION = ".json";

		public const int SAVE_SLOT_COUNT = 5;

		public const string SAVE_GAME_PREFIX = "SaveGame_";

		public const bool DEBUG = false;

		public const bool PRETTY_PRINT = true;

		public static bool SaveError;

		public List<ISaveable> Saveables;

		public List<IBaseSaveable> BaseSaveables;

		[HideInInspector]
		public List<string> ApprovedBaseLevelPaths;

		protected List<ISaveable> CompletedSaveables;

		protected List<SaveRequest> QueuedSaveRequests;

		[Header("References")]
		public RectTransform WriteIssueDisplay;

		[Header("Events")]
		public UnityEvent onSaveStart;

		public UnityEvent onSaveComplete;

		private bool saveFolderInitialized;

		public bool AccessPermissionIssueDetected { get; protected set; }

		public bool IsSaving { get; protected set; }

		public float SecondsSinceLastSave { get; protected set; }

		public string PlayersSavePath { get; protected set; }

		public string IndividualSavesContainerPath { get; protected set; }

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

		public void DelayedSave()
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

		public void CompleteSaveable(ISaveable saveable)
		{
		}

		public void ClearCompletedSaveable(ISaveable saveable)
		{
		}

		public void RegisterSaveable(ISaveable saveable)
		{
		}

		public void QueueSaveRequest(SaveRequest request)
		{
		}

		public void DequeueSaveRequest(SaveRequest request)
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

		public void DisablePlayTutorial(SaveInfo info)
		{
		}

		public static string SanitizeFileName(string fileName)
		{
			return null;
		}
	}
}
