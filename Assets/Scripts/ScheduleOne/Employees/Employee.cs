namespace ScheduleOne.Employees
{
	public class Employee : global::ScheduleOne.NPCs.NPC
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

		public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;

		public bool DEBUG;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Employees.EEmployeeType Type;

		[global::UnityEngine.Header("Payment")]
		public float SigningFee;

		public float DailyWage;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.NPCs.Behaviour.IdleBehaviour WaitOutside;

		public global::ScheduleOne.NPCs.Behaviour.MoveItemBehaviour MoveItemBehaviour;

		public global::ScheduleOne.Dialogue.DialogueContainer BedNotAssignedDialogue;

		public global::ScheduleOne.Dialogue.DialogueContainer NotPaidDialogue;

		public global::ScheduleOne.Dialogue.DialogueContainer WorkIssueDialogueTemplate;

		public global::ScheduleOne.Dialogue.DialogueContainer FireDialogue;

		public global::ScheduleOne.Dialogue.DialogueContainer TransferDialogue;

		private global::System.Collections.Generic.List<global::ScheduleOne.Employees.Employee.NoWorkReason> WorkIssues;

		protected bool initialized;

		protected int consecutivePathingFailures;

		private float timeOnLastPathingFailure;

		private global::UnityEngine.Transform cachedNPCSpawnPoint;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar____003CPaidForToday_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EEmployees_002EEmployeeAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEmployees_002EEmployeeAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Property.Property AssignedProperty { get; protected set; }

		public int EmployeeIndex { get; protected set; }

		public bool PaidForToday
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return false;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
			}
		}

		public bool Fired { get; private set; }

		public bool IsWaitingOutside => false;

		public bool IsMale { get; private set; }

		protected int AppearanceIndex { get; private set; }

		public global::ScheduleOne.Employees.EEmployeeType EmployeeType => default(global::ScheduleOne.Employees.EEmployeeType);

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

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public virtual void Initialize(global::FishNet.Connection.NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		protected virtual void AssignProperty(global::ScheduleOne.Property.Property prop, bool warp)
		{
		}

		protected virtual void UnassignProperty()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendTransfer(string propertyCode)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void TransferToProperty(string code)
		{
		}

		protected virtual void TransferToProperty(global::ScheduleOne.Property.Property prop)
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

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendFire()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveFire()
		{
		}

		protected virtual void ResetConfiguration()
		{
		}

		protected virtual void Fire()
		{
		}

		protected bool CanWork()
		{
			return false;
		}

		protected override void OnDestroy()
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

		protected override void MinPass()
		{
		}

		private void OnSleepEnd()
		{
		}

		public void SetIsPaid()
		{
		}

		public override bool ShouldSave()
		{
			return false;
		}

		public override global::ScheduleOne.Persistence.Datas.NPCData GetNPCData()
		{
			return null;
		}

		public virtual global::ScheduleOne.Employees.EmployeeHome GetHome()
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

		public virtual bool GetWorkIssue(out global::ScheduleOne.Dialogue.DialogueContainer notWorkingReason)
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

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
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

		private void TradeItems()
		{
		}

		private void TradeItemsDone()
		{
		}

		protected void SetDestination(global::ScheduleOne.Management.ITransitEntity transitEntity, bool teleportIfFail = true)
		{
		}

		protected void SetDestination(global::UnityEngine.Vector3 position, bool teleportIfFail = true)
		{
		}

		protected virtual void WalkCallback(global::ScheduleOne.NPCs.NPCMovement.WalkResult result)
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

		private void RpcWriter___Observers_Initialize_2260823878(global::FishNet.Connection.NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		public virtual void RpcLogic___Initialize_2260823878(global::FishNet.Connection.NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		private void RpcReader___Observers_Initialize_2260823878(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Initialize_2260823878(global::FishNet.Connection.NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		private void RpcReader___Target_Initialize_2260823878(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendTransfer_3615296227(string propertyCode)
		{
		}

		public void RpcLogic___SendTransfer_3615296227(string propertyCode)
		{
		}

		private void RpcReader___Server_SendTransfer_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_TransferToProperty_3615296227(string code)
		{
		}

		private void RpcLogic___TransferToProperty_3615296227(string code)
		{
		}

		private void RpcReader___Observers_TransferToProperty_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendFire_2166136261()
		{
		}

		public void RpcLogic___SendFire_2166136261()
		{
		}

		private void RpcReader___Server_SendFire_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveFire_2166136261()
		{
		}

		private void RpcLogic___ReceiveFire_2166136261()
		{
		}

		private void RpcReader___Observers_ReceiveFire_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
		}

		public void RpcLogic___SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
		}

		private void RpcReader___Observers_SubmitNoWorkReason_15643032(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEmployees_002EEmployee(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
