using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Dialogue;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Schedules;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Product;
using ScheduleOne.Quests;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	public class Dealer : NPC, IItemSlotOwner
	{
		public const int MAX_CUSTOMERS = 8;

		public const int DEAL_ARRIVAL_DELAY = 30;

		public const int MIN_TRAVEL_TIME = 15;

		public const int MAX_TRAVEL_TIME = 360;

		public const int OVERFLOW_SLOT_COUNT = 10;

		public const float CASH_REMINDER_THRESHOLD = 500f;

		public const float RELATIONSHIP_CHANGE_PER_DEAL = 0.05f;

		public static Action<Dealer> onDealerRecruited;

		public static Color32 DealerLabelColor;

		public static List<Dealer> AllDealers;

		[Header("Debug")]
		public List<Customer> InitialCustomers;

		public List<ProductDefinition> InitialItems;

		[Header("Dealer References")]
		public NPCEnterableBuilding Home;

		public NPCSignal_HandleDeal DealSignal;

		public NPCEvent_StayInBuilding HomeEvent;

		public DialogueController_Dealer DialogueController;

		[Header("Dialogue stuff")]
		public DialogueContainer RecruitDialogue;

		public DialogueContainer CollectCashDialogue;

		public DialogueContainer AssignCustomersDialogue;

		[Header("Dealer Settings")]
		public string HomeName;

		public float SigningFee;

		public float Cut;

		public bool SellInsufficientQualityItems;

		public bool SellExcessQualityItems;

		[Header("Variables")]
		public string CompletedDealsVariable;

		public List<Customer> AssignedCustomers;

		public List<Contract> ActiveContracts;

		public UnityEvent onRecommended;

		protected ItemSlot[] OverflowSlots;

		private Contract currentContract;

		private DialogueController.DialogueChoice recruitChoice;

		private DialogueController.DialogueChoice collectCashChoice;

		private DialogueController.DialogueChoice assignCustomersChoice;

		[SyncVar]
		public List<string> acceptedContractGUIDs;

		private int itemCountOnTradeStart;

		public SyncVar<float> syncVar____003CCash_003Ek__BackingField;

		public SyncVar<List<string>> syncVar___acceptedContractGUIDs;

		private bool NetworkInitialize___EarlyScheduleOne_002EEconomy_002EDealerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEconomy_002EDealerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsRecruited { get; private set; }

		public List<ItemSlot> ItemSlots { get; set; }

		[field: SyncVar(OnChange = "UpdateCollectCashChoice")]
		public float Cash { get; private set; }

		public bool HasBeenRecommended { get; private set; }

		public NPCPoI potentialDealerPoI { get; protected set; }

		public NPCPoI dealerPoI { get; protected set; }

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

		public List<string> SyncAccessor_acceptedContractGUIDs
		{
			get
			{
				return null;
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

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		private void SetupPoI()
		{
		}

		private void SetUpDialogue()
		{
		}

		protected override void MinPass()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void MarkAsRecommended()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetRecommended()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void InitialRecruitment()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void SetIsRecruited(NetworkConnection conn)
		{
		}

		protected virtual void OnDealerUnlocked(NPCRelationData.EUnlockType unlockType, bool b)
		{
		}

		protected virtual void UpdatePotentialDealerPoI()
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

		private void UpdateCurrentDeal()
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

		public virtual bool ShouldAcceptContract(ContractInfo contractInfo, Customer customer)
		{
			return false;
		}

		public virtual void ContractedOffered(ContractInfo contractInfo, Customer customer)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendAddCustomer(string npcID)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void AddCustomer(NetworkConnection conn, string npcID)
		{
		}

		protected virtual void AddCustomer(Customer customer)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendRemoveCustomer(string npcID)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void RemoveCustomer(string npcID)
		{
		}

		public virtual void RemoveCustomer(Customer customer)
		{
		}

		public void ChangeCash(float change)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SetCash(float cash)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public virtual void CompletedDeal()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SubmitPayment(float payment)
		{
		}

		public List<ProductDefinition> GetOrderableProducts()
		{
			return null;
		}

		public int GetProductCount(string productID, EQuality minQuality, EQuality maxQuality)
		{
			return 0;
		}

		private EDealWindow GetDealWindow()
		{
			return default(EDealWindow);
		}

		private int GetContractCountInWindow(EDealWindow window)
		{
			return 0;
		}

		private void CustomerContractStarted(Contract contract)
		{
		}

		private void CustomerContractEnded(Contract contract)
		{
		}

		private void SortContracts()
		{
		}

		protected virtual void RecruitmentRequested()
		{
		}

		public bool RemoveContractItems(Contract contract, EQuality targetQuality, out List<ItemInstance> items)
		{
			items = null;
			return false;
		}

		private List<ItemInstance> GetItems(string ID, int requiredQuantity, Func<ProductItemInstance, bool> qualityCheck, out int returnedQuantity)
		{
			returnedQuantity = default(int);
			return null;
		}

		public List<ItemSlot> GetAllSlots()
		{
			return null;
		}

		public void AddItemToInventory(ItemInstance item)
		{
		}

		public void TryMoveOverflowItems()
		{
		}

		public int GetTotalInventoryItemCount()
		{
			return 0;
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		public override string GetSaveString()
		{
			return null;
		}

		public override void Load(NPCData data, string containerPath)
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

		private void RpcReader___Server_MarkAsRecommended_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetRecommended_2166136261()
		{
		}

		private void RpcLogic___SetRecommended_2166136261()
		{
		}

		private void RpcReader___Observers_SetRecommended_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_InitialRecruitment_2166136261()
		{
		}

		public void RpcLogic___InitialRecruitment_2166136261()
		{
		}

		private void RpcReader___Server_InitialRecruitment_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetIsRecruited_328543758(NetworkConnection conn)
		{
		}

		public virtual void RpcLogic___SetIsRecruited_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetIsRecruited_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendAddCustomer_3615296227(string npcID)
		{
		}

		public void RpcLogic___SendAddCustomer_3615296227(string npcID)
		{
		}

		private void RpcReader___Server_SendAddCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
		}

		private void RpcLogic___AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
		}

		private void RpcReader___Observers_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
		}

		private void RpcReader___Target_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendRemoveCustomer_3615296227(string npcID)
		{
		}

		public void RpcLogic___SendRemoveCustomer_3615296227(string npcID)
		{
		}

		private void RpcReader___Server_SendRemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_RemoveCustomer_3615296227(string npcID)
		{
		}

		private void RpcLogic___RemoveCustomer_3615296227(string npcID)
		{
		}

		private void RpcReader___Observers_RemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetCash_431000436(float cash)
		{
		}

		public void RpcLogic___SetCash_431000436(float cash)
		{
		}

		private void RpcReader___Server_SetCash_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_CompletedDeal_2166136261()
		{
		}

		public virtual void RpcLogic___CompletedDeal_2166136261()
		{
		}

		private void RpcReader___Server_CompletedDeal_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SubmitPayment_431000436(float payment)
		{
		}

		public void RpcLogic___SubmitPayment_431000436(float payment)
		{
		}

		private void RpcReader___Server_SubmitPayment_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEconomy_002EDealer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEconomy_002EDealer_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
