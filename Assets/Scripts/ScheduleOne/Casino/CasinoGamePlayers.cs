namespace ScheduleOne.Casino
{
	public class CasinoGamePlayers : global::FishNet.Object.NetworkBehaviour
	{
		public int PlayerLimit;

		private global::ScheduleOne.PlayerScripts.Player[] Players;

		public global::UnityEngine.Events.UnityEvent onPlayerListChanged;

		public global::UnityEngine.Events.UnityEvent onPlayerScoresChanged;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.PlayerScripts.Player, int> playerScores;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.PlayerScripts.Player, global::ScheduleOne.Casino.CasinoGamePlayerData> playerDatas;

		private bool NetworkInitialize___EarlyScheduleOne_002ECasino_002ECasinoGamePlayersAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECasino_002ECasinoGamePlayersAssembly_002DCSharp_002Edll_Excuted;

		public int CurrentPlayerCount => 0;

		public virtual void Awake()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void AddPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public void RemovePlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public void SetPlayerScore(global::ScheduleOne.PlayerScripts.Player player, int score)
		{
		}

		public int GetPlayerScore(global::ScheduleOne.PlayerScripts.Player player)
		{
			return 0;
		}

		public global::ScheduleOne.PlayerScripts.Player GetPlayer(int index)
		{
			return null;
		}

		public int GetPlayerIndex(global::ScheduleOne.PlayerScripts.Player player)
		{
			return 0;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestAddPlayer(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		private void AddPlayerToArray(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void RequestRemovePlayer(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		private void RemovePlayerFromArray(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void RequestSetScore(global::FishNet.Object.NetworkObject playerObject, int score)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetPlayerScore(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, int score)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetPlayerList(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject[] playerObjects)
		{
		}

		public global::ScheduleOne.Casino.CasinoGamePlayerData GetPlayerData()
		{
			return null;
		}

		public global::ScheduleOne.Casino.CasinoGamePlayerData GetPlayerData(global::ScheduleOne.PlayerScripts.Player player)
		{
			return null;
		}

		public global::ScheduleOne.Casino.CasinoGamePlayerData GetPlayerData(int index)
		{
			return null;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerBool(global::FishNet.Object.NetworkObject playerObject, string key, bool value)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void ReceivePlayerBool(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, string key, bool value)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerFloat(global::FishNet.Object.NetworkObject playerObject, string key, float value)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void ReceivePlayerFloat(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, string key, float value)
		{
		}

		private global::FishNet.Object.NetworkObject[] GetPlayerObjects()
		{
			return null;
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_RequestAddPlayer_3323014238(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		private void RpcLogic___RequestAddPlayer_3323014238(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		private void RpcReader___Server_RequestAddPlayer_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RequestRemovePlayer_3323014238(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		private void RpcLogic___RequestRemovePlayer_3323014238(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		private void RpcReader___Server_RequestRemovePlayer_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RequestSetScore_4172557123(global::FishNet.Object.NetworkObject playerObject, int score)
		{
		}

		private void RpcLogic___RequestSetScore_4172557123(global::FishNet.Object.NetworkObject playerObject, int score)
		{
		}

		private void RpcReader___Server_RequestSetScore_4172557123(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetPlayerScore_1865307316(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, int score)
		{
		}

		private void RpcLogic___SetPlayerScore_1865307316(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, int score)
		{
		}

		private void RpcReader___Observers_SetPlayerScore_1865307316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetPlayerScore_1865307316(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, int score)
		{
		}

		private void RpcReader___Target_SetPlayerScore_1865307316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetPlayerList_204172449(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject[] playerObjects)
		{
		}

		private void RpcLogic___SetPlayerList_204172449(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject[] playerObjects)
		{
		}

		private void RpcReader___Observers_SetPlayerList_204172449(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetPlayerList_204172449(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject[] playerObjects)
		{
		}

		private void RpcReader___Target_SetPlayerList_204172449(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendPlayerBool_77262511(global::FishNet.Object.NetworkObject playerObject, string key, bool value)
		{
		}

		public void RpcLogic___SendPlayerBool_77262511(global::FishNet.Object.NetworkObject playerObject, string key, bool value)
		{
		}

		private void RpcReader___Server_SendPlayerBool_77262511(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceivePlayerBool_1748594478(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, string key, bool value)
		{
		}

		private void RpcLogic___ReceivePlayerBool_1748594478(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, string key, bool value)
		{
		}

		private void RpcReader___Observers_ReceivePlayerBool_1748594478(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceivePlayerBool_1748594478(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, string key, bool value)
		{
		}

		private void RpcReader___Target_ReceivePlayerBool_1748594478(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendPlayerFloat_2931762093(global::FishNet.Object.NetworkObject playerObject, string key, float value)
		{
		}

		public void RpcLogic___SendPlayerFloat_2931762093(global::FishNet.Object.NetworkObject playerObject, string key, float value)
		{
		}

		private void RpcReader___Server_SendPlayerFloat_2931762093(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceivePlayerFloat_2317689966(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, string key, float value)
		{
		}

		private void RpcLogic___ReceivePlayerFloat_2317689966(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, string key, float value)
		{
		}

		private void RpcReader___Observers_ReceivePlayerFloat_2317689966(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceivePlayerFloat_2317689966(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject playerObject, string key, float value)
		{
		}

		private void RpcReader___Target_ReceivePlayerFloat_2317689966(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002ECasino_002ECasinoGamePlayers_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
