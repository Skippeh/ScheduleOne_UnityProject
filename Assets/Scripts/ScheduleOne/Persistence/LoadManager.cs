namespace ScheduleOne.Persistence
{
	public class LoadManager : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.Persistence.LoadManager>
	{
		public enum ELoadStatus
		{
			None = 0,
			LoadingScene = 1,
			Initializing = 2,
			LoadingData = 3,
			SpawningPlayer = 4,
			WaitingForHost = 5
		}

		public const int LOADS_PER_FRAME = 50;

		public const bool DEBUG = false;

		public const float LOAD_ERROR_TIMEOUT = 90f;

		public const float NETWORK_TIMEOUT = 30f;

		public static global::System.Collections.Generic.List<string> LoadHistory;

		public static global::ScheduleOne.Persistence.SaveInfo[] SaveGames;

		public static global::ScheduleOne.Persistence.SaveInfo LastPlayedGame;

		private global::System.Collections.Generic.List<global::ScheduleOne.Persistence.LoadRequest> loadRequests;

		public global::System.Collections.Generic.List<global::ScheduleOne.Persistence.ItemLoaders.ItemLoader> ItemLoaders;

		public global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Loaders.BuildableItemLoader> ObjectLoaders;

		public global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Loaders.LegacyNPCLoader> LegacyNPCLoaders;

		public global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Loaders.NPCLoader> NPCLoaders;

		public global::UnityEngine.Events.UnityEvent onPreSceneChange;

		public global::UnityEngine.Events.UnityEvent onPreLoad;

		public global::UnityEngine.Events.UnityEvent onLoadComplete;

		public global::UnityEngine.Events.UnityEvent onSaveInfoLoaded;

		public string DefaultTutorialSaveFolder => null;

		public bool IsGameLoaded { get; protected set; }

		public bool IsLoading { get; protected set; }

		public float TimeSinceGameLoaded { get; protected set; }

		public bool DebugMode { get; protected set; }

		public global::ScheduleOne.Persistence.LoadManager.ELoadStatus LoadStatus { get; protected set; }

		public string LoadedGameFolderPath { get; protected set; }

		public global::ScheduleOne.Persistence.SaveInfo ActiveSaveInfo { get; private set; }

		public global::ScheduleOne.Persistence.SaveInfo StoredSaveInfo { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Bananas()
		{
		}

		private void InitializeItemLoaders()
		{
		}

		private void InitializeObjectLoaders()
		{
		}

		private void InitializeNPCLoaders()
		{
		}

		public void Update()
		{
		}

		public void QueueLoadRequest(global::ScheduleOne.Persistence.LoadRequest request)
		{
		}

		public void DequeueLoadRequest(global::ScheduleOne.Persistence.LoadRequest request)
		{
		}

		public global::ScheduleOne.Persistence.ItemLoaders.ItemLoader GetItemLoader(string itemType)
		{
			return null;
		}

		public global::ScheduleOne.Persistence.Loaders.BuildableItemLoader GetObjectLoader(string objectType)
		{
			return null;
		}

		public global::ScheduleOne.Persistence.Loaders.LegacyNPCLoader GetLegacyNPCLoader(string npcType)
		{
			return null;
		}

		public global::ScheduleOne.Persistence.Loaders.NPCLoader GetNPCLoader(string npcType)
		{
			return null;
		}

		public string GetLoadStatusText()
		{
			return null;
		}

		public void StartGame(global::ScheduleOne.Persistence.SaveInfo info, bool allowLoadStacking = false)
		{
		}

		public void LoadTutorialAsClient()
		{
		}

		public void LoadAsClient(string steamId64)
		{
		}

		private void StartLoadErrorAutosubmit()
		{
		}

		public void SetWaitingForHostLoad()
		{
		}

		public void LoadLastSave()
		{
		}

		private void CleanUp()
		{
		}

		public void ExitToMenu(global::ScheduleOne.Persistence.SaveInfo autoLoadSave = null, global::ScheduleOne.UI.MainMenu.MainMenuPopup.Data mainMenuPopup = null, bool preventLeaveLobby = false)
		{
		}

		public static bool TryLoadSaveInfo(string saveFolderPath, int saveSlotIndex, out global::ScheduleOne.Persistence.SaveInfo saveInfo, bool requireGameFile = false)
		{
			saveInfo = null;
			return false;
		}

		public void RefreshSaveInfo()
		{
		}
	}
}
