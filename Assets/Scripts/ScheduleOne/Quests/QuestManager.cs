namespace ScheduleOne.Quests
{
	public class QuestManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Quests.QuestManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		public enum EQuestAction
		{
			Begin = 0,
			Success = 1,
			Fail = 2,
			Expire = 3,
			Cancel = 4
		}

		public const global::ScheduleOne.Quests.EQuestState DEFAULT_QUEST_STATE = global::ScheduleOne.Quests.EQuestState.Inactive;

		public global::ScheduleOne.Quests.Quest[] DefaultQuests;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform QuestContainer;

		public global::UnityEngine.Transform ContractContainer;

		public global::ScheduleOne.Audio.AudioSourceController QuestCompleteSound;

		public global::ScheduleOne.Audio.AudioSourceController QuestEntryCompleteSound;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.Quests.Contract ContractPrefab;

		public global::ScheduleOne.Quests.DeaddropQuest DeaddropCollectionPrefab;

		private global::ScheduleOne.Persistence.Loaders.QuestsLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EQuests_002EQuestManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EQuests_002EQuestManagerAssembly_002DCSharp_002Edll_Excuted;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		public override void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		protected override void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void UpdateVariables()
		{
		}

		public global::ScheduleOne.Quests.Contract ContractAccepted(global::ScheduleOne.Economy.Customer customer, global::ScheduleOne.Quests.ContractInfo contractData, bool track, string guid, global::ScheduleOne.Economy.Dealer dealer)
		{
			return null;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void CreateContract_Networked(global::FishNet.Connection.NetworkConnection conn, string title, string description, string guid, bool tracked, global::FishNet.Object.NetworkObject customer, global::ScheduleOne.Quests.ContractInfo contractData, global::ScheduleOne.GameTime.GameDateTime expiry, global::ScheduleOne.GameTime.GameDateTime acceptTime, global::FishNet.Object.NetworkObject dealerObj = null)
		{
		}

		public global::ScheduleOne.Quests.Contract CreateContract_Local(string title, string description, global::ScheduleOne.Persistence.Datas.QuestEntryData[] entries, string guid, bool tracked, global::ScheduleOne.Economy.Customer customer, float payment, global::ScheduleOne.Product.ProductList products, string deliveryLocationGUID, global::ScheduleOne.Quests.QuestWindowConfig deliveryWindow, bool expires, global::ScheduleOne.GameTime.GameDateTime expiry, int pickupScheduleIndex, global::ScheduleOne.GameTime.GameDateTime acceptTime, global::ScheduleOne.Economy.Dealer dealer = null)
		{
			return null;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestAction(string guid, global::ScheduleOne.Quests.QuestManager.EQuestAction action)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void ReceiveQuestAction(global::FishNet.Connection.NetworkConnection conn, string guid, global::ScheduleOne.Quests.QuestManager.EQuestAction action)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestState(string guid, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void ReceiveQuestState(global::FishNet.Connection.NetworkConnection conn, string guid, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		[global::FishNet.Object.TargetRpc]
		private void SetQuestTracked(global::FishNet.Connection.NetworkConnection conn, string guid, bool tracked)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendQuestEntryState(string guid, int entryIndex, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void ReceiveQuestEntryState(global::FishNet.Connection.NetworkConnection conn, string guid, int entryIndex, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		[global::EasyButtons.Button]
		public void PrintQuestStates()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void CreateDeaddropCollectionQuest(global::FishNet.Connection.NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		public global::ScheduleOne.Quests.DeaddropQuest CreateDeaddropCollectionQuest(string dropGUID, string guidString = "")
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

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Observers_CreateContract_Networked_2526053753(global::FishNet.Connection.NetworkConnection conn, string title, string description, string guid, bool tracked, global::FishNet.Object.NetworkObject customer, global::ScheduleOne.Quests.ContractInfo contractData, global::ScheduleOne.GameTime.GameDateTime expiry, global::ScheduleOne.GameTime.GameDateTime acceptTime, global::FishNet.Object.NetworkObject dealerObj = null)
		{
		}

		public void RpcLogic___CreateContract_Networked_2526053753(global::FishNet.Connection.NetworkConnection conn, string title, string description, string guid, bool tracked, global::FishNet.Object.NetworkObject customer, global::ScheduleOne.Quests.ContractInfo contractData, global::ScheduleOne.GameTime.GameDateTime expiry, global::ScheduleOne.GameTime.GameDateTime acceptTime, global::FishNet.Object.NetworkObject dealerObj = null)
		{
		}

		private void RpcReader___Observers_CreateContract_Networked_2526053753(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_CreateContract_Networked_2526053753(global::FishNet.Connection.NetworkConnection conn, string title, string description, string guid, bool tracked, global::FishNet.Object.NetworkObject customer, global::ScheduleOne.Quests.ContractInfo contractData, global::ScheduleOne.GameTime.GameDateTime expiry, global::ScheduleOne.GameTime.GameDateTime acceptTime, global::FishNet.Object.NetworkObject dealerObj = null)
		{
		}

		private void RpcReader___Target_CreateContract_Networked_2526053753(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendQuestAction_2848227116(string guid, global::ScheduleOne.Quests.QuestManager.EQuestAction action)
		{
		}

		public void RpcLogic___SendQuestAction_2848227116(string guid, global::ScheduleOne.Quests.QuestManager.EQuestAction action)
		{
		}

		private void RpcReader___Server_SendQuestAction_2848227116(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveQuestAction_920727549(global::FishNet.Connection.NetworkConnection conn, string guid, global::ScheduleOne.Quests.QuestManager.EQuestAction action)
		{
		}

		private void RpcLogic___ReceiveQuestAction_920727549(global::FishNet.Connection.NetworkConnection conn, string guid, global::ScheduleOne.Quests.QuestManager.EQuestAction action)
		{
		}

		private void RpcReader___Observers_ReceiveQuestAction_920727549(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveQuestAction_920727549(global::FishNet.Connection.NetworkConnection conn, string guid, global::ScheduleOne.Quests.QuestManager.EQuestAction action)
		{
		}

		private void RpcReader___Target_ReceiveQuestAction_920727549(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendQuestState_4117703421(string guid, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		public void RpcLogic___SendQuestState_4117703421(string guid, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		private void RpcReader___Server_SendQuestState_4117703421(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveQuestState_3887376304(global::FishNet.Connection.NetworkConnection conn, string guid, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		private void RpcLogic___ReceiveQuestState_3887376304(global::FishNet.Connection.NetworkConnection conn, string guid, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		private void RpcReader___Observers_ReceiveQuestState_3887376304(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveQuestState_3887376304(global::FishNet.Connection.NetworkConnection conn, string guid, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		private void RpcReader___Target_ReceiveQuestState_3887376304(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetQuestTracked_619441887(global::FishNet.Connection.NetworkConnection conn, string guid, bool tracked)
		{
		}

		private void RpcLogic___SetQuestTracked_619441887(global::FishNet.Connection.NetworkConnection conn, string guid, bool tracked)
		{
		}

		private void RpcReader___Target_SetQuestTracked_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendQuestEntryState_375159588(string guid, int entryIndex, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		public void RpcLogic___SendQuestEntryState_375159588(string guid, int entryIndex, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		private void RpcReader___Server_SendQuestEntryState_375159588(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveQuestEntryState_311789429(global::FishNet.Connection.NetworkConnection conn, string guid, int entryIndex, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		private void RpcLogic___ReceiveQuestEntryState_311789429(global::FishNet.Connection.NetworkConnection conn, string guid, int entryIndex, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		private void RpcReader___Observers_ReceiveQuestEntryState_311789429(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveQuestEntryState_311789429(global::FishNet.Connection.NetworkConnection conn, string guid, int entryIndex, global::ScheduleOne.Quests.EQuestState state)
		{
		}

		private void RpcReader___Target_ReceiveQuestEntryState_311789429(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758(global::FishNet.Connection.NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		public void RpcLogic___CreateDeaddropCollectionQuest_3895153758(global::FishNet.Connection.NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		private void RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758(global::FishNet.Connection.NetworkConnection conn, string dropGUID, string guidString = "")
		{
		}

		private void RpcReader___Target_CreateDeaddropCollectionQuest_3895153758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EQuests_002EQuestManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
