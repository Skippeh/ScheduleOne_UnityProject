using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using ScheduleOne.Messaging;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.UI.Phone;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	public class Supplier : NPC
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

		public static Color32 SupplierLabelColor;

		[Header("Supplier Settings")]
		public float MinOrderLimit;

		public float MaxOrderLimit;

		public PhoneShopInterface.Listing[] OnlineShopItems;

		[TextArea(3, 10)]
		public string SupplierRecommendMessage;

		[TextArea(3, 10)]
		public string SupplierUnlockHint;

		[Header("References")]
		public ShopInterface Shop;

		public SupplierStash Stash;

		public UnityEvent onDeaddropReady;

		private int minsSinceMeetingStart;

		private int minsSinceLastMeetingEnd;

		private SupplierLocation currentLocation;

		private DialogueController dialogueController;

		private DialogueController.GreetingOverride meetingGreeting;

		private DialogueController.DialogueChoice meetingChoice;

		[SyncVar]
		public float debt;

		[SyncVar]
		public bool deadDropPreparing;

		private StringIntPair[] deaddropItems;

		private int minsSinceDeaddropOrder;

		private bool repaymentReminderSent;

		public SyncVar<float> syncVar___debt;

		public SyncVar<bool> syncVar___deadDropPreparing;

		private bool NetworkInitialize___EarlyScheduleOne_002EEconomy_002ESupplierAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEconomy_002ESupplierAssembly_002DCSharp_002Edll_Excuted;

		public ESupplierStatus Status { get; private set; }

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

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SendUnlocked()
		{
		}

		[ObserversRpc]
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

		[ObserversRpc(RunLocally = true)]
		public void MeetAtLocation(NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		public void EndMeeting()
		{
		}

		protected virtual void SupplierUnlocked(NPCRelationData.EUnlockType type, bool notify)
		{
		}

		protected virtual void RelationshipChange(float change)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void EnableDeliveries(NetworkConnection conn)
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

		protected virtual void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SetDeaddrop(StringIntPair[] items, int minsUntilReady)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
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

		protected SupplierLocation GetAppropriateLocation(out int locationIndex)
		{
			locationIndex = default(int);
			return null;
		}

		private bool IsDeadDropValid(SendableMessage message, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		private bool IsMeetupValid(SendableMessage message, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public virtual float GetDeadDropLimit()
		{
			return 0f;
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

		private void RpcWriter___Server_SendUnlocked_2166136261()
		{
		}

		public void RpcLogic___SendUnlocked_2166136261()
		{
		}

		private void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetUnlocked_2166136261()
		{
		}

		private void RpcLogic___SetUnlocked_2166136261()
		{
		}

		private void RpcReader___Observers_SetUnlocked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		public void RpcLogic___MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
		}

		private void RpcReader___Observers_MeetAtLocation_3470796954(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_EnableDeliveries_328543758(NetworkConnection conn)
		{
		}

		private void RpcLogic___EnableDeliveries_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_EnableDeliveries_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetDeaddrop_3971994486(StringIntPair[] items, int minsUntilReady)
		{
		}

		private void RpcLogic___SetDeaddrop_3971994486(StringIntPair[] items, int minsUntilReady)
		{
		}

		private void RpcReader___Server_SetDeaddrop_3971994486(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_ChangeDebt_431000436(float amount)
		{
		}

		private void RpcLogic___ChangeDebt_431000436(float amount)
		{
		}

		private void RpcReader___Server_ChangeDebt_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEconomy_002ESupplier(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EEconomy_002ESupplier_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
