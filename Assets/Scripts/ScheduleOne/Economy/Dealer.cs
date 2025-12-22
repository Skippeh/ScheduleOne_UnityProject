namespace ScheduleOne.Economy
{
	public class Dealer : global::ScheduleOne.NPCs.NPC, global::ScheduleOne.ItemFramework.IItemSlotOwner
	{
		public const int MAX_CUSTOMERS = 8;

		public const int DEAL_ARRIVAL_DELAY = 30;

		public const int MIN_TRAVEL_TIME = 15;

		public const int MAX_TRAVEL_TIME = 360;

		public const int OVERFLOW_SLOT_COUNT = 10;

		public const float CASH_REMINDER_THRESHOLD = 500f;

		public const float RELATIONSHIP_CHANGE_PER_DEAL = 0.05f;

		public static global::UnityEngine.Color32 DealerLabelColor;

		public static global::System.Action<global::ScheduleOne.Economy.Dealer> onDealerRecruited;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Economy.Dealer> AllPlayerDealers;

		public global::System.Action onContractAccepted;

		[global::UnityEngine.Header("Dealer References")]
		public global::ScheduleOne.Map.NPCEnterableBuilding Home;

		public global::ScheduleOne.NPCs.Schedules.NPCEvent_StayInBuilding HomeEvent;

		public global::ScheduleOne.Dialogue.DialogueController_Dealer DialogueController;

		[global::UnityEngine.Header("Dialogue stuff")]
		public global::ScheduleOne.Dialogue.DialogueContainer RecruitDialogue;

		public global::ScheduleOne.Dialogue.DialogueContainer CollectCashDialogue;

		public global::ScheduleOne.Dialogue.DialogueContainer AssignCustomersDialogue;

		[global::UnityEngine.Header("Dealer Settings")]
		public global::ScheduleOne.Economy.EDealerType DealerType;

		public string HomeName;

		public float SigningFee;

		public float Cut;

		public bool SellInsufficientQualityItems;

		public bool SellExcessQualityItems;

		[global::UnityEngine.Header("Variables")]
		public string CompletedDealsVariable;

		[global::UnityEngine.Header("UnityEvents")]
		public global::UnityEngine.Events.UnityEvent onRecommended;

		public global::UnityEngine.Events.UnityEvent onCompleteDeal;

		private global::ScheduleOne.ItemFramework.ItemSlot[] overflowSlots;

		private global::ScheduleOne.Quests.Contract currentContract;

		private global::ScheduleOne.Dialogue.DialogueController.DialogueChoice recruitChoice;

		private global::ScheduleOne.Dialogue.DialogueController.DialogueChoice collectCashChoice;

		private global::ScheduleOne.Dialogue.DialogueController.DialogueChoice assignCustomersChoice;

		private int itemCountOnTradeStart;

		private global::ScheduleOne.NPCs.Behaviour.DealerAttendDealBehaviour _attendDealBehaviour;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar____003CCash_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EEconomy_002EDealerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEconomy_002EDealerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsRecruited { get; private set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> ItemSlots { get; set; }

		public global::ScheduleOne.Map.NPCPoI PotentialDealerPoI { get; private set; }

		public global::ScheduleOne.Map.NPCPoI DealerPoI { get; private set; }

		public float Cash
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return 0f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
			}
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Economy.Customer> AssignedCustomers { get; private set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.Quests.Contract> ActiveContracts { get; private set; }

		public bool HasBeenRecommended { get; private set; }

		public float SyncAccessor__003CCash_003Ek__BackingField
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		protected override void OnValidate()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void SetupPoI()
		{
		}

		private void SetUpDialogue()
		{
		}

		protected override void OnTick()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void MarkAsRecommended()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetRecommended()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void InitialRecruitment()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public virtual void SetIsRecruited(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void OnDealerUnlocked(global::ScheduleOne.NPCs.Relation.NPCRelationData.EUnlockType unlockType, bool b)
		{
		}

		protected virtual void UpdatePotentialDealerPoI()
		{
		}

		private void DealerUnconscious()
		{
		}

		private void TradeItems()
		{
		}

		private void TradeItemsDone()
		{
		}

		private bool CanCollectCash(out string reason)
		{
			reason = null;
			return false;
		}

		private void UpdateCollectCashChoice(float oldCash, float newCash, bool asServer)
		{
		}

		private void CollectCash()
		{
		}

		private void CheckCurrentDealValidity()
		{
		}

		private bool CanOfferRecruitment(out string reason)
		{
			reason = null;
			return false;
		}

		private void CheckAttendStart()
		{
		}

		public virtual bool ShouldAcceptContract(global::ScheduleOne.Quests.ContractInfo contractInfo, global::ScheduleOne.Economy.Customer customer)
		{
			return false;
		}

		public virtual void ContractedOffered(global::ScheduleOne.Quests.ContractInfo contractInfo, global::ScheduleOne.Economy.Customer customer)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendAddCustomer(string npcID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void AddCustomer(global::FishNet.Connection.NetworkConnection conn, string npcID)
		{
		}

		protected virtual void AddCustomer(global::ScheduleOne.Economy.Customer customer)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendRemoveCustomer(string npcID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void RemoveCustomer(string npcID)
		{
		}

		public virtual void RemoveCustomer(global::ScheduleOne.Economy.Customer customer)
		{
		}

		public void ChangeCash(float change)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SetCash(float cash)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public virtual void CompletedDeal()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SubmitPayment(float payment)
		{
		}

		public void TryRobDealer()
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductDefinition> GetOrderableProducts()
		{
			return null;
		}

		public int GetProductCount(string productID, global::ScheduleOne.ItemFramework.EQuality minQuality, global::ScheduleOne.ItemFramework.EQuality maxQuality)
		{
			return 0;
		}

		private global::ScheduleOne.Economy.EDealWindow GetDealWindow()
		{
			return default(global::ScheduleOne.Economy.EDealWindow);
		}

		private int GetContractCountInWindow(global::ScheduleOne.Economy.EDealWindow window)
		{
			return 0;
		}

		private void AddContract(global::ScheduleOne.Quests.Contract contract)
		{
		}

		private void CustomerContractEnded(global::ScheduleOne.Quests.Contract contract)
		{
		}

		private void SortContracts()
		{
		}

		protected virtual void RecruitmentRequested()
		{
		}

		public bool RemoveContractItems(global::ScheduleOne.Quests.Contract contract, global::ScheduleOne.ItemFramework.EQuality targetQuality, out global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items)
		{
			items = null;
			return false;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> GetItems(string ID, int requiredQuantity, global::System.Func<global::ScheduleOne.Product.ProductItemInstance, bool> qualityCheck, out int returnedQuantity)
		{
			returnedQuantity = default(int);
			return null;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> GetAllSlots()
		{
			return null;
		}

		public void AddItemToInventory(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public void TryMoveOverflowItems()
		{
		}

		public int GetTotalInventoryItemCount()
		{
			return 0;
		}

		public int GetPackagedProductAmount()
		{
			return 0;
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetStoredInstance_Internal(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetSlotFilter_Internal(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		public override global::ScheduleOne.Persistence.Datas.NPCData GetNPCData()
		{
			return null;
		}

		public override void Load(global::ScheduleOne.Persistence.Datas.DynamicSaveData dynamicData, global::ScheduleOne.Persistence.Datas.NPCData npcData)
		{
		}

		public override void Load(global::ScheduleOne.Persistence.Datas.NPCData data, string containerPath)
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

		private void RpcWriter___Server_MarkAsRecommended_2166136261()
		{
		}

		public void RpcLogic___MarkAsRecommended_2166136261()
		{
		}

		private void RpcReader___Server_MarkAsRecommended_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetRecommended_2166136261()
		{
		}

		private void RpcLogic___SetRecommended_2166136261()
		{
		}

		private void RpcReader___Observers_SetRecommended_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_InitialRecruitment_2166136261()
		{
		}

		public void RpcLogic___InitialRecruitment_2166136261()
		{
		}

		private void RpcReader___Server_InitialRecruitment_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetIsRecruited_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual void RpcLogic___SetIsRecruited_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_SetIsRecruited_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetIsRecruited_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_SetIsRecruited_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendAddCustomer_3615296227(string npcID)
		{
		}

		public void RpcLogic___SendAddCustomer_3615296227(string npcID)
		{
		}

		private void RpcReader___Server_SendAddCustomer_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_AddCustomer_2971853958(global::FishNet.Connection.NetworkConnection conn, string npcID)
		{
		}

		private void RpcLogic___AddCustomer_2971853958(global::FishNet.Connection.NetworkConnection conn, string npcID)
		{
		}

		private void RpcReader___Observers_AddCustomer_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_AddCustomer_2971853958(global::FishNet.Connection.NetworkConnection conn, string npcID)
		{
		}

		private void RpcReader___Target_AddCustomer_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendRemoveCustomer_3615296227(string npcID)
		{
		}

		public void RpcLogic___SendRemoveCustomer_3615296227(string npcID)
		{
		}

		private void RpcReader___Server_SendRemoveCustomer_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_RemoveCustomer_3615296227(string npcID)
		{
		}

		private void RpcLogic___RemoveCustomer_3615296227(string npcID)
		{
		}

		private void RpcReader___Observers_RemoveCustomer_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetCash_431000436(float cash)
		{
		}

		public void RpcLogic___SetCash_431000436(float cash)
		{
		}

		private void RpcReader___Server_SetCash_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_CompletedDeal_2166136261()
		{
		}

		public virtual void RpcLogic___CompletedDeal_2166136261()
		{
		}

		private void RpcReader___Server_CompletedDeal_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SubmitPayment_431000436(float payment)
		{
		}

		public void RpcLogic___SubmitPayment_431000436(float payment)
		{
		}

		private void RpcReader___Server_SubmitPayment_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetStoredInstance_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		public void RpcLogic___SetStoredInstance_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcReader___Server_SetStoredInstance_2652194801(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcLogic___SetStoredInstance_Internal_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Server_SetItemSlotQuantity_1692629761(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetSlotLocked_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		public void RpcLogic___SetSlotLocked_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Server_SetSlotLocked_3170825843(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcLogic___SetSlotLocked_Internal_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetSlotFilter_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		public void RpcLogic___SetSlotFilter_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcReader___Server_SetSlotFilter_527532783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcLogic___SetSlotFilter_Internal_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcReader___Target_SetSlotFilter_Internal_527532783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEconomy_002EDealer(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEconomy_002EDealer_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
