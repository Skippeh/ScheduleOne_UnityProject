using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Dialogue;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Employees
{
	public class Employee : NPC
	{
		public class NoWorkReason
		{
			public string Reason;

			public string Fix;

			public int Priority;

			public NoWorkReason(string reason, string fix, int priority)
			{
			}
		}

		public bool DEBUG;

		[SerializeField]
		protected EEmployeeType Type;

		[Header("Payment")]
		public float SigningFee;

		public float DailyWage;

		[Header("References")]
		public IdleBehaviour WaitOutside;

		public MoveItemBehaviour MoveItemBehaviour;

		public DialogueContainer BedNotAssignedDialogue;

		public DialogueContainer NotPaidDialogue;

		public DialogueContainer WorkIssueDialogueTemplate;

		public DialogueContainer FireDialogue;

		private List<NoWorkReason> WorkIssues;

		protected bool initialized;

		public SyncVar<bool> syncVar____003CPaidForToday_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EEmployees_002EEmployeeAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEmployees_002EEmployeeAssembly_002DCSharp_002Edll_Excuted;

		public ScheduleOne.Property.Property AssignedProperty { get; protected set; }

		public int EmployeeIndex { get; protected set; }

		[field: SyncVar]
		public bool PaidForToday { get; private set; }

		public bool Fired { get; private set; }

		public bool IsWaitingOutside => false;

		public bool IsMale { get; private set; }

		protected int AppearanceIndex { get; private set; }

		public EEmployeeType EmployeeType => default(EEmployeeType);

		public int TimeSinceLastWorked { get; private set; }

		public bool SyncAccessor__003CPaidForToday_003Ek__BackingField
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		public override void OnStartServer()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void Initialize(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		protected virtual void AssignProperty(ScheduleOne.Property.Property prop)
		{
		}

		protected virtual void InitializeInfo(string firstName, string lastName, string id)
		{
		}

		protected virtual void InitializeAppearance(bool male, int index)
		{
		}

		protected virtual void CheckDialogueChoice(string choiceLabel)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SendFire()
		{
		}

		[ObserversRpc]
		private void ReceiveFire()
		{
		}

		protected virtual void Fire()
		{
		}

		protected bool CanWork()
		{
			return false;
		}

		protected new virtual void OnDestroy()
		{
		}

		protected virtual void UpdateBehaviour()
		{
		}

		protected void MarkIsWorking()
		{
		}

		private void SetWaitOutside(bool wait)
		{
		}

		protected virtual bool ShouldIdle()
		{
			return false;
		}

		protected override bool ShouldNoticeGeneralCrime(Player player)
		{
			return false;
		}

		protected override void MinPass()
		{
		}

		private void OnSleepEnd(int sleepTime)
		{
		}

		public void SetIsPaid()
		{
		}

		public override bool ShouldSave()
		{
			return false;
		}

		public override string GetSaveString()
		{
			return null;
		}

		public virtual BedItem GetBed()
		{
			return null;
		}

		public bool IsPayAvailable()
		{
			return false;
		}

		public void RemoveDailyWage()
		{
		}

		public virtual bool GetWorkIssue(out DialogueContainer notWorkingReason)
		{
			notWorkingReason = null;
			return false;
		}

		public virtual void SetIdle(bool idle)
		{
		}

		protected void LeavePropertyAndDespawn()
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void SubmitNoWorkReason(string reason, string fix, int priority = 0)
		{
		}

		private bool ShouldShowNoWorkDialogue(bool enabled)
		{
			return false;
		}

		private void OnNotWorkingDialogue()
		{
		}

		private bool ShouldShowFireDialogue(bool enabled)
		{
			return false;
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

		private void RpcWriter___Observers_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		public virtual void RpcLogic___Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		private void RpcReader___Observers_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		private void RpcReader___Target_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendFire_2166136261()
		{
		}

		public void RpcLogic___SendFire_2166136261()
		{
		}

		private void RpcReader___Server_SendFire_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveFire_2166136261()
		{
		}

		private void RpcLogic___ReceiveFire_2166136261()
		{
		}

		private void RpcReader___Observers_ReceiveFire_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
		}

		public void RpcLogic___SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
		}

		private void RpcReader___Observers_SubmitNoWorkReason_15643032(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEmployees_002EEmployee(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
