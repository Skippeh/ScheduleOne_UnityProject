using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.ItemLoaders;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.UI.MainMenu;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	public class LoadManager : PersistentSingleton<LoadManager>
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

		public static List<string> LoadHistory;

		public static SaveInfo[] SaveGames;

		public static SaveInfo LastPlayedGame;

		private List<LoadRequest> loadRequests;

		public List<ItemLoader> ItemLoaders;

		public List<BuildableItemLoader> ObjectLoaders;

		public List<NPCLoader> NPCLoaders;

		public UnityEvent onPreSceneChange;

		public UnityEvent onPreLoad;

		public UnityEvent onLoadComplete;

		public UnityEvent onSaveInfoLoaded;

		public string DefaultTutorialSaveFolder => null;

		public bool IsGameLoaded { get; protected set; }

		public bool IsLoading { get; protected set; }

		public float TimeSinceGameLoaded { get; protected set; }

		public bool DebugMode { get; protected set; }

		public ELoadStatus LoadStatus { get; protected set; }

		public string LoadedGameFolderPath { get; protected set; }

		public SaveInfo ActiveSaveInfo { get; private set; }

		public SaveInfo StoredSaveInfo { get; private set; }

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

		public void QueueLoadRequest(LoadRequest request)
		{
		}

		public void DequeueLoadRequest(LoadRequest request)
		{
		}

		public ItemLoader GetItemLoader(string itemType)
		{
			return null;
		}

		public BuildableItemLoader GetObjectLoader(string objectType)
		{
			return null;
		}

		public NPCLoader GetNPCLoader(string npcType)
		{
			return null;
		}

		public string GetLoadStatusText()
		{
			return null;
		}

		public void StartGame(SaveInfo info, bool allowLoadStacking = false)
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

		public void ExitToMenu(SaveInfo autoLoadSave = null, MainMenuPopup.Data mainMenuPopup = null, bool preventLeaveLobby = false)
		{
		}

		public void RefreshSaveInfo()
		{
		}
	}
}
