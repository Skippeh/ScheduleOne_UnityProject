namespace ScheduleOne.Economy
{
	[global::UnityEngine.DisallowMultipleComponent]
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.NPCs.NPC))]
	public class Customer : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.Persistence.ISaveable
	{
		[global::System.Serializable]
		public class ScheduleGroupPair
		{
			public global::UnityEngine.GameObject NormalScheduleGroup;

			public global::UnityEngine.GameObject CurfewScheduleGroup;
		}

		[global::System.Serializable]
		public class CustomerPreference
		{
			public global::ScheduleOne.Product.EDrugType DrugType;

			[global::UnityEngine.Header("Optionally, a specific product")]
			public global::ScheduleOne.Product.ProductDefinition Definition;

			public global::ScheduleOne.ItemFramework.EQuality MinimumQuality;
		}

		public enum ESampleFeedback
		{
			WrongProduct = 0,
			WrongQuality = 1,
			Correct = 2
		}

		public static global::System.Action<global::ScheduleOne.Economy.Customer> onCustomerUnlocked;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Economy.Customer> LockedCustomers;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Economy.Customer> UnlockedCustomers;

		public const float AFFINITY_MAX_EFFECT = 0.3f;

		public const float PROPERTY_MAX_EFFECT = 0.4f;

		public const float QUALITY_MAX_EFFECT = 0.3f;

		public const float DEAL_REJECTED_RELATIONSHIP_CHANGE = -0.5f;

		public const int ATTACK_DEAL_COOLDOWN = 48;

		public const float RELATIONSHIP_THRESHOLD_TO_GIVE_DEAL_TO_CARTEL = 0.25f;

		public const float CUSTOMER_UNLOCKED_CARTEL_INFLUENCE_CHANGE = -0.075f;

		public bool DEBUG;

		public const float APPROACH_MIN_ADDICTION = 0.33f;

		public const float APPROACH_CHANCE_PER_DAY_MAX = 0.5f;

		public const float APPROACH_MIN_COOLDOWN = 2160f;

		public const float APPROACH_MAX_COOLDOWN = 4320f;

		public const int DEAL_COOLDOWN = 600;

		public static string[] PlayerAcceptMessages;

		public static string[] PlayerRejectMessages;

		public const int DEAL_ATTENDANCE_TOLERANCE = 10;

		public const int MIN_TRAVEL_TIME = 15;

		public const int MAX_TRAVEL_TIME = 360;

		public const int OFFER_EXPIRY_TIME_MINS = 600;

		public const float MIN_ORDER_APPEAL = 0.05f;

		public const float ADDICTION_DRAIN_PER_DAY = 0.0625f;

		public const bool SAMPLE_REQUIRES_RECOMMENDATION = false;

		public const float MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION = 0.5f;

		public const float RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION = 0.6f;

		public const float RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION = 0.6f;

		private global::ScheduleOne.Quests.ContractInfo offeredContractInfo;

		public global::ScheduleOne.NPCs.Schedules.NPCSignal_WaitForDelivery DealSignal;

		[global::UnityEngine.Header("Settings")]
		public bool AvailableInDemo;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Economy.CustomerData customerData;

		public global::ScheduleOne.Economy.DeliveryLocation DefaultDeliveryLocation;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent onUnlocked;

		public global::UnityEngine.Events.UnityEvent onDealCompleted;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Quests.Contract> onContractAssigned;

		private bool awaitingSample;

		private global::ScheduleOne.Dialogue.DialogueController.DialogueChoice sampleChoice;

		private global::ScheduleOne.Dialogue.DialogueController.DialogueChoice completeContractChoice;

		private global::ScheduleOne.Dialogue.DialogueController.DialogueChoice offerDealChoice;

		private global::ScheduleOne.Dialogue.DialogueController.GreetingOverride awaitingDealGreeting;

		private int minsSinceUnlocked;

		private bool sampleOfferedToday;

		private global::ScheduleOne.Economy.CustomerAffinityData currentAffinityData;

		private bool pendingInstantDeal;

		private global::ScheduleOne.Product.ProductItemInstance consumedSample;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar____003CCurrentAddiction_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar____003CHasBeenRecommended_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EEconomy_002ECustomerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEconomy_002ECustomerAssembly_002DCSharp_002Edll_Excuted;

		public float CurrentAddiction
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return 0f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
			}
		}

		public global::ScheduleOne.Quests.ContractInfo OfferedContractInfo
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public global::ScheduleOne.GameTime.GameDateTime OfferedContractTime { get; protected set; }

		public global::ScheduleOne.Quests.Contract CurrentContract { get; protected set; }

		public bool IsAwaitingDelivery { get; protected set; }

		public int TimeSinceLastDealCompleted { get; protected set; }

		public int TimeSinceLastDealOffered { get; protected set; }

		public int TimeSincePlayerApproached { get; protected set; }

		public int TimeSinceInstantDealOffered { get; protected set; }

		public int OfferedDeals { get; protected set; }

		public int CompletedDeliveries { get; protected set; }

		public bool HasBeenRecommended
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return false;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
			}
		}

		public global::ScheduleOne.NPCs.NPC NPC { get; protected set; }

		public global::ScheduleOne.Economy.Dealer AssignedDealer { get; protected set; }

		public global::ScheduleOne.Economy.CustomerData CustomerData => null;

		private global::ScheduleOne.Dialogue.DialogueDatabase dialogueDatabase => null;

		public global::ScheduleOne.Map.NPCPoI potentialCustomerPoI { get; private set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public float SyncAccessor__003CCurrentAddiction_003Ek__BackingField
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool SyncAccessor__003CHasBeenRecommended_003Ek__BackingField
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		protected override void OnValidate()
		{
		}

		private void Start()
		{
		}

		public override void OnStartClient()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void OnDestroy()
		{
		}

		private void SetUpDialogue()
		{
		}

		private void SetupPoI()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		protected virtual void OnMinPass()
		{
		}

		protected virtual void OnTick()
		{
		}

		private void OfferContractToDealer(global::ScheduleOne.Quests.ContractInfo info, global::ScheduleOne.Economy.Dealer dealer)
		{
		}

		protected virtual void OnDayPass()
		{
		}

		private void UpdateDealAttendance()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void ConfigureDealSignal(global::FishNet.Connection.NetworkConnection conn, int startTime, bool active)
		{
		}

		private void UpdateOfferExpiry()
		{
		}

		public void ForceDealOffer()
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductDefinition> GetOrderableProducts(global::ScheduleOne.Economy.Dealer dealer)
		{
			return null;
		}

		private global::ScheduleOne.Quests.ContractInfo TryGenerateContract(global::ScheduleOne.Economy.Dealer dealer)
		{
			return null;
		}

		private global::ScheduleOne.Product.ProductDefinition GetWeightedRandomProduct(global::ScheduleOne.Economy.Dealer dealer, out float appeal)
		{
			appeal = default(float);
			return null;
		}

		protected virtual void OnCustomerUnlocked(global::ScheduleOne.NPCs.Relation.NPCRelationData.EUnlockType unlockType, bool notify)
		{
		}

		public void SetHasBeenRecommended()
		{
		}

		public virtual void OfferContract(global::ScheduleOne.Quests.ContractInfo info)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void SetOfferedContract(global::ScheduleOne.Quests.ContractInfo info, global::ScheduleOne.GameTime.GameDateTime offerTime)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public virtual void ExpireOffer()
		{
		}

		public virtual void AssignContract(global::ScheduleOne.Quests.Contract contract)
		{
		}

		protected virtual void NotifyPlayerOfContract(global::ScheduleOne.Quests.ContractInfo contract, global::ScheduleOne.UI.Phone.Messages.MessageChain offerMessage, bool canAccept, bool canReject, bool canCounterOffer = true)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendSetUpResponseCallbacks()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetUpResponseCallbacks()
		{
		}

		protected virtual void AcceptContractClicked()
		{
		}

		protected virtual void CounterOfferClicked()
		{
		}

		protected virtual void SendCounteroffer(global::ScheduleOne.Product.ProductDefinition product, int quantity, float price)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void ProcessCounterOfferServerSide(string productID, int quantity, float price)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetContractIsCounterOffer()
		{
		}

		protected virtual void PlayerAcceptedContract(global::ScheduleOne.Economy.EDealWindow window)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendContractAccepted(global::ScheduleOne.Economy.EDealWindow window, bool trackContract)
		{
		}

		public global::ScheduleOne.Quests.Contract ContractAccepted(global::ScheduleOne.Economy.EDealWindow window, bool trackContract, global::ScheduleOne.Economy.Dealer dealer)
		{
			return null;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ReceiveContractAccepted()
		{
		}

		protected virtual void PlayContractAcceptedReaction()
		{
		}

		protected virtual bool EvaluateCounteroffer(global::ScheduleOne.Product.ProductDefinition product, int quantity, float price)
		{
			return false;
		}

		public static float GetValueProposition(global::ScheduleOne.Product.ProductDefinition product, float price)
		{
			return 0f;
		}

		protected virtual void ContractRejected()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ReceiveContractRejected()
		{
		}

		protected virtual void PlayContractRejectedReaction()
		{
		}

		public virtual void SetIsAwaitingDelivery(bool awaiting)
		{
		}

		public bool IsAtDealLocation()
		{
			return false;
		}

		private void UpdatePotentialCustomerPoI()
		{
		}

		public void SetPotentialCustomerPoIEnabled(bool enabled)
		{
		}

		protected virtual bool ShouldTryGenerateDeal()
		{
			return false;
		}

		private bool IsDealTime()
		{
			return false;
		}

		public virtual void OfferDealItems(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, bool offeredByPlayer, out bool accepted)
		{
			accepted = default(bool);
		}

		public virtual void CustomerRejectedDeal(bool offeredByPlayer)
		{
		}

		public virtual void ProcessHandover(global::ScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome outcome, global::ScheduleOne.Quests.Contract contract, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, bool handoverByPlayer, bool giveBonuses = true)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void ProcessHandoverServerSide(global::ScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome outcome, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, bool handoverByPlayer, float totalPayment, global::ScheduleOne.Product.ProductList productList, float satisfaction, global::FishNet.Object.NetworkObject dealerObject)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ProcessHandoverClient(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
		}

		public void ContractWellReceived(string npcToRecommend)
		{
		}

		private void RecommendDealer(global::ScheduleOne.Economy.Dealer dealer)
		{
		}

		private void RecommendSupplier(global::ScheduleOne.Economy.Supplier supplier)
		{
		}

		private void RecommendCustomer(global::ScheduleOne.Economy.Customer friend)
		{
		}

		public virtual void CurrentContractEnded(global::ScheduleOne.Quests.EQuestState outcome)
		{
		}

		public virtual float EvaluateDelivery(global::ScheduleOne.Quests.Contract contract, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> providedItems, out float highestAddiction, out global::ScheduleOne.Product.EDrugType mainTypeType, out int matchedProductCount, out float qualityDifference)
		{
			highestAddiction = default(float);
			mainTypeType = default(global::ScheduleOne.Product.EDrugType);
			matchedProductCount = default(int);
			qualityDifference = default(float);
			return 0f;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void ChangeAddiction(float change)
		{
		}

		private void ConsumeProduct(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		protected virtual bool ShowOfferDealOption(bool enabled)
		{
			return false;
		}

		protected virtual bool OfferDealValid(out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		protected virtual void InstantDealOffered()
		{
		}

		public float GetOfferSuccessChance(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, float askingPrice)
		{
			return 0f;
		}

		protected virtual bool ShouldTryApproachPlayer()
		{
			return false;
		}

		[global::EasyButtons.Button]
		public void RequestProduct()
		{
		}

		public void RequestProduct(global::ScheduleOne.PlayerScripts.Player target)
		{
		}

		public void PlayerRejectedProductRequest()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void RejectProductRequestOffer()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void RejectProductRequestOffer_Local()
		{
		}

		public void AssignDealer(global::ScheduleOne.Economy.Dealer dealer)
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public global::ScheduleOne.Persistence.Datas.CustomerData GetCustomerData()
		{
			return null;
		}

		public virtual global::System.Collections.Generic.List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		[global::FishNet.Object.TargetRpc]
		private void ReceiveCustomerData(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.Datas.CustomerData data)
		{
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.CustomerData data)
		{
		}

		protected virtual bool IsReadyForHandover(bool enabled)
		{
			return false;
		}

		protected virtual bool IsHandoverChoiceValid(out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public void HandoverChosen()
		{
		}

		protected virtual bool ShowDirectApproachOption(bool enabled)
		{
			return false;
		}

		public virtual bool IsUnlockable()
		{
			return false;
		}

		protected virtual bool SampleOptionValid(out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public bool KnownAndRecommended()
		{
			return false;
		}

		public void SampleOffered()
		{
		}

		protected virtual float GetSampleRequestSuccessChance()
		{
			return 0f;
		}

		protected virtual void SampleAccepted()
		{
		}

		private float GetSampleSuccess(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, float price)
		{
			return 0f;
		}

		private void ProcessSample(global::ScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome outcome, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, float price)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void ProcessSampleServerSide(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ProcessSampleClient()
		{
		}

		private void SampleConsumed()
		{
		}

		private void EndWait()
		{
		}

		protected virtual void DirectApproachRejected()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void SampleWasSufficient()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void SampleWasInsufficient()
		{
		}

		public float GetProductEnjoyment(global::ScheduleOne.Product.ProductDefinition product, global::ScheduleOne.ItemFramework.EQuality quality)
		{
			return 0f;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Product.EDrugType> GetOrderedDrugTypes()
		{
			return null;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void AdjustAffinity(global::ScheduleOne.Product.EDrugType drugType, float change)
		{
		}

		[global::EasyButtons.Button]
		public void AutocreateCustomerSettings()
		{
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

		private void RpcWriter___Observers_ConfigureDealSignal_338960014(global::FishNet.Connection.NetworkConnection conn, int startTime, bool active)
		{
		}

		private void RpcLogic___ConfigureDealSignal_338960014(global::FishNet.Connection.NetworkConnection conn, int startTime, bool active)
		{
		}

		private void RpcReader___Observers_ConfigureDealSignal_338960014(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ConfigureDealSignal_338960014(global::FishNet.Connection.NetworkConnection conn, int startTime, bool active)
		{
		}

		private void RpcReader___Target_ConfigureDealSignal_338960014(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetOfferedContract_4277245194(global::ScheduleOne.Quests.ContractInfo info, global::ScheduleOne.GameTime.GameDateTime offerTime)
		{
		}

		private void RpcLogic___SetOfferedContract_4277245194(global::ScheduleOne.Quests.ContractInfo info, global::ScheduleOne.GameTime.GameDateTime offerTime)
		{
		}

		private void RpcReader___Observers_SetOfferedContract_4277245194(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ExpireOffer_2166136261()
		{
		}

		public virtual void RpcLogic___ExpireOffer_2166136261()
		{
		}

		private void RpcReader___Server_ExpireOffer_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendSetUpResponseCallbacks_2166136261()
		{
		}

		private void RpcLogic___SendSetUpResponseCallbacks_2166136261()
		{
		}

		private void RpcReader___Server_SendSetUpResponseCallbacks_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetUpResponseCallbacks_2166136261()
		{
		}

		private void RpcLogic___SetUpResponseCallbacks_2166136261()
		{
		}

		private void RpcReader___Observers_SetUpResponseCallbacks_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
		}

		private void RpcLogic___ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
		}

		private void RpcReader___Server_ProcessCounterOfferServerSide_900355577(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetContractIsCounterOffer_2166136261()
		{
		}

		private void RpcLogic___SetContractIsCounterOffer_2166136261()
		{
		}

		private void RpcReader___Observers_SetContractIsCounterOffer_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendContractAccepted_507093020(global::ScheduleOne.Economy.EDealWindow window, bool trackContract)
		{
		}

		private void RpcLogic___SendContractAccepted_507093020(global::ScheduleOne.Economy.EDealWindow window, bool trackContract)
		{
		}

		private void RpcReader___Server_SendContractAccepted_507093020(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveContractAccepted_2166136261()
		{
		}

		private void RpcLogic___ReceiveContractAccepted_2166136261()
		{
		}

		private void RpcReader___Observers_ReceiveContractAccepted_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ReceiveContractRejected_2166136261()
		{
		}

		private void RpcLogic___ReceiveContractRejected_2166136261()
		{
		}

		private void RpcReader___Observers_ReceiveContractRejected_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ProcessHandoverServerSide_3760244802(global::ScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome outcome, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, bool handoverByPlayer, float totalPayment, global::ScheduleOne.Product.ProductList productList, float satisfaction, global::FishNet.Object.NetworkObject dealerObject)
		{
		}

		private void RpcLogic___ProcessHandoverServerSide_3760244802(global::ScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome outcome, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, bool handoverByPlayer, float totalPayment, global::ScheduleOne.Product.ProductList productList, float satisfaction, global::FishNet.Object.NetworkObject dealerObject)
		{
		}

		private void RpcReader___Server_ProcessHandoverServerSide_3760244802(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
		}

		private void RpcLogic___ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
		}

		private void RpcReader___Observers_ProcessHandoverClient_537707335(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ChangeAddiction_431000436(float change)
		{
		}

		public void RpcLogic___ChangeAddiction_431000436(float change)
		{
		}

		private void RpcReader___Server_ChangeAddiction_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RejectProductRequestOffer_2166136261()
		{
		}

		public void RpcLogic___RejectProductRequestOffer_2166136261()
		{
		}

		private void RpcReader___Server_RejectProductRequestOffer_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261()
		{
		}

		private void RpcLogic___RejectProductRequestOffer_Local_2166136261()
		{
		}

		private void RpcReader___Observers_RejectProductRequestOffer_Local_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveCustomerData_2280244125(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.Datas.CustomerData data)
		{
		}

		private void RpcLogic___ReceiveCustomerData_2280244125(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.Datas.CustomerData data)
		{
		}

		private void RpcReader___Target_ReceiveCustomerData_2280244125(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ProcessSampleServerSide_3704012609(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items)
		{
		}

		private void RpcLogic___ProcessSampleServerSide_3704012609(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items)
		{
		}

		private void RpcReader___Server_ProcessSampleServerSide_3704012609(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ProcessSampleClient_2166136261()
		{
		}

		private void RpcLogic___ProcessSampleClient_2166136261()
		{
		}

		private void RpcReader___Observers_ProcessSampleClient_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SampleWasSufficient_2166136261()
		{
		}

		private void RpcLogic___SampleWasSufficient_2166136261()
		{
		}

		private void RpcReader___Observers_SampleWasSufficient_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SampleWasInsufficient_2166136261()
		{
		}

		private void RpcLogic___SampleWasInsufficient_2166136261()
		{
		}

		private void RpcReader___Observers_SampleWasInsufficient_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_AdjustAffinity_3036964899(global::ScheduleOne.Product.EDrugType drugType, float change)
		{
		}

		public void RpcLogic___AdjustAffinity_3036964899(global::ScheduleOne.Product.EDrugType drugType, float change)
		{
		}

		private void RpcReader___Server_AdjustAffinity_3036964899(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEconomy_002ECustomer(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEconomy_002ECustomer_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
