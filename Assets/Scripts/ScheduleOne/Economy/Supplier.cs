namespace ScheduleOne.Economy
{
	public class Supplier : global::ScheduleOne.NPCs.NPC
	{
		public enum ESupplierStatus
		{
			Idle = 0,
			PreppingDeadDrop = 1,
			Meeting = 2
		}

		public const float MEETUP_RELATIONSHIP_REQUIREMENT = 4f;

		public const int MEETUP_DURATION_MINS = 360;

		public const int MEETING_COOLDOWN_MINS = 720;

		public const int DEADDROP_WAIT_PER_ITEM = 30;

		public const int DEADDROP_MAX_WAIT = 360;

		public const int DEADDROP_ITEM_LIMIT = 10;

		public const float DELIVERY_RELATIONSHIP_REQUIREMENT = 5f;

		public static global::UnityEngine.Color32 SupplierLabelColor;

		[global::UnityEngine.Header("Supplier Settings")]
		public float MinOrderLimit;

		public float MaxOrderLimit;

		public global::ScheduleOne.UI.Phone.PhoneShopInterface.Listing[] OnlineShopItems;

		[global::UnityEngine.TextArea(3, 10)]
		public string SupplierRecommendMessage;

		[global::UnityEngine.TextArea(3, 10)]
		public string SupplierUnlockHint;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.Shop.ShopInterface Shop;

		public global::ScheduleOne.Economy.SupplierStash Stash;

		public global::UnityEngine.Events.UnityEvent onDeaddropReady;

		private int minsSinceMeetingStart;

		private int minsSinceLastMeetingEnd;

		private global::ScheduleOne.Economy.SupplierLocation currentLocation;

		private global::ScheduleOne.Dialogue.DialogueController dialogueController;

		private global::ScheduleOne.Dialogue.DialogueController.GreetingOverride meetingGreeting;

		private global::ScheduleOne.Dialogue.DialogueController.DialogueChoice meetingChoice;

		[global::FishNet.Object.Synchronizing.SyncVar]
		public float debt;

		[global::FishNet.Object.Synchronizing.SyncVar]
		public bool deadDropPreparing;

		private global::ScheduleOne.DevUtilities.StringIntPair[] deaddropItems;

		private int minsSinceDeaddropOrder;

		private bool repaymentReminderSent;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar___debt;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar___deadDropPreparing;

		private bool NetworkInitialize___EarlyScheduleOne_002EEconomy_002ESupplierAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEconomy_002ESupplierAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Economy.Supplier.ESupplierStatus Status { get; private set; }

		public bool DeliveriesEnabled { get; private set; }

		public float Debt => 0f;

		public int minsUntilDeaddropReady { get; private set; }

		public float SyncAccessor_debt
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool SyncAccessor_deadDropPreparing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendUnlocked()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void SetUnlocked()
		{
		}

		protected override void MinPass()
		{
		}

		protected void HourPass()
		{
		}

		private void OnTimeSkip(int minsSlept)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void MeetAtLocation(global::FishNet.Connection.NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		public void EndMeeting()
		{
		}

		protected virtual void SupplierUnlocked(global::ScheduleOne.NPCs.Relation.NPCRelationData.EUnlockType type, bool notify)
		{
		}

		protected virtual void RelationshipChange(float change)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void EnableDeliveries(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public void SetUnlockMessage()
		{
		}

		protected override void CreateMessageConversation()
		{
		}

		protected virtual void DeaddropRequested()
		{
		}

		protected virtual void DeaddropConfirmed(global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SetDeaddrop(global::ScheduleOne.DevUtilities.StringIntPair[] items, int minsUntilReady)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void ChangeDebt(float amount)
		{
		}

		private void TryRecoverDebt()
		{
		}

		private void CompleteDeaddrop()
		{
		}

		private void SendDebtReminder()
		{
		}

		protected virtual void MeetupRequested()
		{
		}

		protected virtual void PayDebtRequested()
		{
		}

		protected global::ScheduleOne.Economy.SupplierLocation GetAppropriateLocation(out int locationIndex)
		{
			locationIndex = default(int);
			return null;
		}

		private bool IsDeadDropValid(global::ScheduleOne.Messaging.SendableMessage message, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		private bool IsMeetupValid(global::ScheduleOne.Messaging.SendableMessage message, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public virtual float GetDeadDropLimit()
		{
			return 0f;
		}

		public override global::ScheduleOne.Persistence.Datas.NPCData GetNPCData()
		{
			return null;
		}

		public override void Load(global::ScheduleOne.Persistence.Datas.NPCData data, string containerPath)
		{
		}

		public override void Load(global::ScheduleOne.Persistence.Datas.DynamicSaveData dynamicData, global::ScheduleOne.Persistence.Datas.NPCData npcData)
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

		private void RpcWriter___Server_SendUnlocked_2166136261()
		{
		}

		public void RpcLogic___SendUnlocked_2166136261()
		{
		}

		private void RpcReader___Server_SendUnlocked_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetUnlocked_2166136261()
		{
		}

		private void RpcLogic___SetUnlocked_2166136261()
		{
		}

		private void RpcReader___Observers_SetUnlocked_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_MeetAtLocation_3470796954(global::FishNet.Connection.NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		public void RpcLogic___MeetAtLocation_3470796954(global::FishNet.Connection.NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		private void RpcReader___Observers_MeetAtLocation_3470796954(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_EnableDeliveries_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___EnableDeliveries_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_EnableDeliveries_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_EnableDeliveries_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_EnableDeliveries_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetDeaddrop_3971994486(global::ScheduleOne.DevUtilities.StringIntPair[] items, int minsUntilReady)
		{
		}

		private void RpcLogic___SetDeaddrop_3971994486(global::ScheduleOne.DevUtilities.StringIntPair[] items, int minsUntilReady)
		{
		}

		private void RpcReader___Server_SetDeaddrop_3971994486(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_ChangeDebt_431000436(float amount)
		{
		}

		private void RpcLogic___ChangeDebt_431000436(float amount)
		{
		}

		private void RpcReader___Server_ChangeDebt_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEconomy_002ESupplier(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEconomy_002ESupplier_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
