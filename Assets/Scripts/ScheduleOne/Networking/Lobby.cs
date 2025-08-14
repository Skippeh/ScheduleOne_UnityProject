namespace ScheduleOne.Networking
{
	public class Lobby : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.Networking.Lobby>
	{
		public const bool ENABLED = true;

		public const int PLAYER_LIMIT = 4;

		public const string JOIN_READY = "ready";

		public const string LOAD_TUTORIAL = "load_tutorial";

		public const string HOST_LOADING = "host_loading";

		public global::Steamworks.CSteamID[] Players;

		public global::System.Action onLobbyChange;

		private global::Steamworks.Callback<global::Steamworks.LobbyCreated_t> LobbyCreatedCallback;

		private global::Steamworks.Callback<global::Steamworks.LobbyEnter_t> LobbyEnteredCallback;

		private global::Steamworks.Callback<global::Steamworks.LobbyChatUpdate_t> ChatUpdateCallback;

		private global::Steamworks.Callback<global::Steamworks.GameLobbyJoinRequested_t> GameLobbyJoinRequestedCallback;

		private global::Steamworks.Callback<global::Steamworks.LobbyChatMsg_t> LobbyChatMessageCallback;

		public bool IsHost => false;

		public ulong LobbyID { get; private set; }

		public global::Steamworks.CSteamID LobbySteamID => default(global::Steamworks.CSteamID);

		public bool IsInLobby => false;

		public int PlayerCount => 0;

		public global::Steamworks.CSteamID LocalPlayerID { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void InitializeCallbacks()
		{
		}

		public void TryOpenInviteInterface()
		{
		}

		public void LeaveLobby()
		{
		}

		private void CreateLobby()
		{
		}

		private string GetLaunchLobby()
		{
			return null;
		}

		private void UpdateLobbyMembers()
		{
		}

		public void JoinAsClient(string steamId64)
		{
		}

		public void SendLobbyMessage(string message)
		{
		}

		public void SetLobbyData(string key, string value)
		{
		}

		private void OnLobbyCreated(global::Steamworks.LobbyCreated_t result)
		{
		}

		private void OnLobbyEntered(global::Steamworks.LobbyEnter_t result)
		{
		}

		private void PlayerEnterOrLeave(global::Steamworks.LobbyChatUpdate_t result)
		{
		}

		private void LobbyJoinRequested(global::Steamworks.GameLobbyJoinRequested_t result)
		{
		}

		private void OnLobbyChatMessage(global::Steamworks.LobbyChatMsg_t result)
		{
		}
	}
}
