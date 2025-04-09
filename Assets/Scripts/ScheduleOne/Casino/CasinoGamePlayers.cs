using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.PlayerScripts;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	public class CasinoGamePlayers : NetworkBehaviour
	{
		public int PlayerLimit;

		private Player[] Players;

		public UnityEvent onPlayerListChanged;

		public UnityEvent onPlayerScoresChanged;

		private Dictionary<Player, int> playerScores;

		private Dictionary<Player, CasinoGamePlayerData> playerDatas;

		private bool NetworkInitialize___EarlyScheduleOne_002ECasino_002ECasinoGamePlayersAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECasino_002ECasinoGamePlayersAssembly_002DCSharp_002Edll_Excuted;

		public int CurrentPlayerCount => 0;

		public virtual void Awake()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void AddPlayer(Player player)
		{
		}

		public void RemovePlayer(Player player)
		{
		}

		public void SetPlayerScore(Player player, int score)
		{
		}

		public int GetPlayerScore(Player player)
		{
			return 0;
		}

		public Player GetPlayer(int index)
		{
			return null;
		}

		public int GetPlayerIndex(Player player)
		{
			return 0;
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void RequestAddPlayer(NetworkObject playerObject)
		{
		}

		private void AddPlayerToArray(Player player)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void RequestRemovePlayer(NetworkObject playerObject)
		{
		}

		private void RemovePlayerFromArray(Player player)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void RequestSetScore(NetworkObject playerObject, int score)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetPlayerScore(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetPlayerList(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		public CasinoGamePlayerData GetPlayerData()
		{
			return null;
		}

		public CasinoGamePlayerData GetPlayerData(Player player)
		{
			return null;
		}

		public CasinoGamePlayerData GetPlayerData(int index)
		{
			return null;
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerBool(NetworkObject playerObject, string key, bool value)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceivePlayerBool(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPlayerFloat(NetworkObject playerObject, string key, float value)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceivePlayerFloat(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		private NetworkObject[] GetPlayerObjects()
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

		private void RpcWriter___Server_RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
		}

		private void RpcLogic___RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
		}

		private void RpcReader___Server_RequestAddPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
		}

		private void RpcLogic___RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
		}

		private void RpcReader___Server_RequestRemovePlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
		}

		private void RpcLogic___RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
		}

		private void RpcReader___Server_RequestSetScore_4172557123(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		private void RpcLogic___SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		private void RpcReader___Observers_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
		}

		private void RpcReader___Target_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		private void RpcLogic___SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		private void RpcReader___Observers_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetPlayerList_204172449(NetworkConnection conn, NetworkObject[] playerObjects)
		{
		}

		private void RpcReader___Target_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
		}

		public void RpcLogic___SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
		}

		private void RpcReader___Server_SendPlayerBool_77262511(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		private void RpcLogic___ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		private void RpcReader___Observers_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
		}

		private void RpcReader___Target_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
		}

		public void RpcLogic___SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
		}

		private void RpcReader___Server_SendPlayerFloat_2931762093(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		private void RpcLogic___ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		private void RpcReader___Observers_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
		}

		private void RpcReader___Target_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002ECasino_002ECasinoGamePlayers_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
