namespace ScheduleOne.Cartel
{
	public class CartelDealManager : global::FishNet.Object.NetworkBehaviour
	{
		public const int DEAL_DUE_TIME_DAYS = 3;

		public const float PAYMENT_MULTIPLIER = 0.65f;

		public const int DEAL_COOLDOWN_HOURS = 24;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.NPCs.NPC RequestingNPC;

		public global::ScheduleOne.Quests.Quest_DealForCartel DealQuest;

		public global::ScheduleOne.Storage.WorldStorageEntity DeliveryEntity;

		public global::UnityEngine.Transform CashSpawnPoint;

		public global::ScheduleOne.Quests.Quest MethRequestPrereqQuest;

		public global::ScheduleOne.Economy.Supplier CokeRequestPrereqSupplier;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.ItemFramework.CashPickup CashPrefab;

		public global::ScheduleOne.Product.ProductDefinition[] RequestableWeed;

		public global::ScheduleOne.Product.ProductDefinition MethDefinition;

		public global::ScheduleOne.Product.ProductDefinition CocaineDefinition;

		public int ProductQuantityMin;

		public int ProductQuantityMax;

		private bool NetworkInitialize___EarlyScheduleOne_002ECartel_002ECartelDealManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECartel_002ECartelDealManagerAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Cartel.CartelDealInfo ActiveDeal { get; private set; }

		public int HoursUntilNextDealRequest { get; private set; }

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void MinPass()
		{
		}

		private void OnTimeSkip(int mins)
		{
		}

		private void HourPass()
		{
		}

		public void SetHoursUntilDealRequest(int hours)
		{
		}

		private void SleepEnd()
		{
		}

		private void MarkDealOverdue()
		{
		}

		private void ExpireDeal()
		{
		}

		private void CheckDealCompletion()
		{
		}

		private void CompleteDeal()
		{
		}

		private void DepositCash(float amount)
		{
		}

		[global::EasyButtons.Button]
		private void StartDeal()
		{
		}

		public void LoadDeal(global::ScheduleOne.Cartel.CartelDealInfo dealInfo)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void InitializeDealQuest(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelDealInfo dealInfo)
		{
		}

		private void SendRequestMessage(global::ScheduleOne.Cartel.CartelDealInfo dealInfo)
		{
		}

		private void SendOverdueMessage()
		{
		}

		private void SendExpiryMessage()
		{
		}

		public void Load(global::ScheduleOne.Persistence.Datas.CartelData data)
		{
		}

		private void CartelStatusChange(ECartelStatus oldStatus, ECartelStatus newStatus)
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

		private void RpcWriter___Observers_InitializeDealQuest_2137933519(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelDealInfo dealInfo)
		{
		}

		private void RpcLogic___InitializeDealQuest_2137933519(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelDealInfo dealInfo)
		{
		}

		private void RpcReader___Observers_InitializeDealQuest_2137933519(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_InitializeDealQuest_2137933519(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelDealInfo dealInfo)
		{
		}

		private void RpcReader___Target_InitializeDealQuest_2137933519(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002ECartel_002ECartelDealManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
