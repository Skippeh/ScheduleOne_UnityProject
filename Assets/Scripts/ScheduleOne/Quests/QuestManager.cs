using System.Collections.Generic;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Economy;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.Quests
{
	public class QuestManager : NetworkSingleton<QuestManager>, IBaseSaveable, ISaveable
	{
		public enum EQuestAction
		{
			Begin = 0,
			Success = 1,
			Fail = 2,
			Expire = 3,
			Cancel = 4
		}

		public const EQuestState DEFAULT_QUEST_STATE = EQuestState.Inactive;

		public Quest[] DefaultQuests;

		[Header("References")]
		public Transform QuestContainer;

		public Transform ContractContainer;

		public AudioSourceController QuestCompleteSound;

		public AudioSourceController QuestEntryCompleteSound;

		[Header("Prefabs")]
		public Contract ContractPrefab;

		public DeaddropQuest DeaddropCollectionPrefab;

		private QuestsLoader loader;

		private List<string> writtenContractFiles;

		private bool NetworkInitialize___EarlyScheduleOne_002EQuests_002EQuestManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EQuests_002EQuestManagerAssembly_002DCSharp_002Edll_Excuted;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public override void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		protected override void Start()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		private void UpdateVariables()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SendContractAccepted(NetworkObject customer, ContractInfo contractData, bool track, string guid)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void CreateContract_Networked(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
		}

		public Contract CreateContract_Local(string title, string description, QuestEntryData[] entries, string guid, bool tracked, NetworkObject customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, GameDateTime expiry, int pickupScheduleIndex, GameDateTime acceptTime, Dealer dealer = null)
		{
			return null;
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestAction(string guid, EQuestAction action)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceiveQuestAction(NetworkConnection conn, string guid, EQuestAction action)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestState(string guid, EQuestState state)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceiveQuestState(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		[TargetRpc]
		private void SetQuestTracked(NetworkConnection conn, string guid, bool tracked)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestEntryState(string guid, int entryIndex, EQuestState state)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceiveQuestEntryState(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		[Button]
		public void PrintQuestStates()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void CreateDeaddropCollectionQuest(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		public DeaddropQuest CreateDeaddropCollectionQuest(string dropGUID, string guidString = "")
		{
			return null;
		}

		public void PlayCompleteQuestSound()
		{
		}

		public void PlayCompleteQuestEntrySound()
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_SendContractAccepted_1030683829(NetworkObject customer, ContractInfo contractData, bool track, string guid)
		{
		}

		public void RpcLogic___SendContractAccepted_1030683829(NetworkObject customer, ContractInfo contractData, bool track, string guid)
		{
		}

		private void RpcReader___Server_SendContractAccepted_1030683829(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_CreateContract_Networked_1113640585(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
		}

		public void RpcLogic___CreateContract_Networked_1113640585(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
		}

		private void RpcReader___Observers_CreateContract_Networked_1113640585(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_CreateContract_Networked_1113640585(NetworkConnection conn, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
		}

		private void RpcReader___Target_CreateContract_Networked_1113640585(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendQuestAction_2848227116(string guid, EQuestAction action)
		{
		}

		public void RpcLogic___SendQuestAction_2848227116(string guid, EQuestAction action)
		{
		}

		private void RpcReader___Server_SendQuestAction_2848227116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, EQuestAction action)
		{
		}

		private void RpcLogic___ReceiveQuestAction_920727549(NetworkConnection conn, string guid, EQuestAction action)
		{
		}

		private void RpcReader___Observers_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, EQuestAction action)
		{
		}

		private void RpcReader___Target_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendQuestState_4117703421(string guid, EQuestState state)
		{
		}

		public void RpcLogic___SendQuestState_4117703421(string guid, EQuestState state)
		{
		}

		private void RpcReader___Server_SendQuestState_4117703421(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		private void RpcLogic___ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		private void RpcReader___Observers_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
		}

		private void RpcReader___Target_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
		{
		}

		private void RpcLogic___SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
		{
		}

		private void RpcReader___Target_SetQuestTracked_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
		{
		}

		public void RpcLogic___SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
		{
		}

		private void RpcReader___Server_SendQuestEntryState_375159588(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		private void RpcLogic___ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		private void RpcReader___Observers_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
		}

		private void RpcReader___Target_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		public void RpcLogic___CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		private void RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		private void RpcReader___Target_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EQuests_002EQuestManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
