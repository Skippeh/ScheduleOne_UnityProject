using System;
using EasyButtons;
using FishNet.Managing;
using ScheduleOne.DevUtilities;
using Steamworks;

namespace ScheduleOne.Networking
{
	public class Lobby : PersistentSingleton<Lobby>
	{
		public const bool ENABLED = true;

		public const int PLAYER_LIMIT = 4;

		public const string JOIN_READY = "ready";

		public const string LOAD_TUTORIAL = "load_tutorial";

		public const string HOST_LOADING = "host_loading";

		public NetworkManager NetworkManager;

		public CSteamID[] Players;

		public Action onLobbyChange;

		private Callback<LobbyCreated_t> LobbyCreatedCallback;

		private Callback<LobbyEnter_t> LobbyEnteredCallback;

		private Callback<LobbyChatUpdate_t> ChatUpdateCallback;

		private Callback<GameLobbyJoinRequested_t> GameLobbyJoinRequestedCallback;

		private Callback<LobbyChatMsg_t> LobbyChatMessageCallback;

		public string DebugSteamId64;

		public bool IsHost => false;

		public ulong LobbyID { get; private set; }

		public CSteamID LobbySteamID => default(CSteamID);

		public bool IsInLobby => false;

		public int PlayerCount => 0;

		public CSteamID LocalPlayerID { get; private set; }

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

		[Button]
		public void DebugJoin()
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

		private void OnLobbyCreated(LobbyCreated_t result)
		{
		}

		private void OnLobbyEntered(LobbyEnter_t result)
		{
		}

		private void PlayerEnterOrLeave(LobbyChatUpdate_t result)
		{
		}

		private void LobbyJoinRequested(GameLobbyJoinRequested_t result)
		{
		}

		private void OnLobbyChatMessage(LobbyChatMsg_t result)
		{
		}
	}
}
