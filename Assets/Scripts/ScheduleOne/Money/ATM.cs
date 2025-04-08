namespace ScheduleOne.Money
{
	public class ATM : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.IGUIDRegisterable, global::ScheduleOne.Persistence.IGenericSaveable
	{
		public const bool DepositLimitEnabled = true;

		public const float WEEKLY_DEPOSIT_LIMIT = 10000f;

		public const float IMPACT_THRESHOLD_BREAK = 165f;

		public const int REPAIR_TIME_DAYS = 2;

		public const int MIN_CASH_DROP = 2;

		public const int MAX_CASH_DROP = 8;

		public static float WeeklyDepositSum;

		public global::ScheduleOne.ItemFramework.CashPickup CashPrefab;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject intObj;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform camPos;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.UI.ATM.ATMInterface interfaceATM;

		public global::UnityEngine.Transform AccessPoint;

		public global::UnityEngine.Transform CashSpawnPoint;

		public global::ScheduleOne.Combat.PhysicsDamageable Damageable;

		[global::UnityEngine.Header("Settings")]
		public static float viewLerpTime;

		[global::UnityEngine.SerializeField]
		protected string BakedGUID;

		public global::UnityEngine.Events.UnityEvent onBreak;

		public global::UnityEngine.Events.UnityEvent onRepair;

		private bool NetworkInitialize___EarlyScheduleOne_002EMoney_002EATMAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMoney_002EATMAssembly_002DCSharp_002Edll_Excuted;

		public bool IsBroken { get; protected set; }

		public int DaysUntilRepair { get; protected set; }

		public bool isInUse { get; protected set; }

		public global::System.Guid GUID { get; protected set; }

		[global::EasyButtons.Button]
		public void RegenerateGUID()
		{
		}

		public virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		public void DayPass()
		{
		}

		public void WeekPass()
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		public void Enter()
		{
		}

		public void Exit()
		{
		}

		private void Impacted(global::ScheduleOne.Combat.Impact impact)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBreak()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void Break(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void Repair()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void DropCash()
		{
		}

		public void Load(global::ScheduleOne.Persistence.Datas.GenericSaveData data)
		{
		}

		public global::ScheduleOne.Persistence.Datas.GenericSaveData GetSaveData()
		{
			return null;
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

		private void RpcWriter___Server_SendBreak_2166136261()
		{
		}

		private void RpcLogic___SendBreak_2166136261()
		{
		}

		private void RpcReader___Server_SendBreak_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Break_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___Break_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Break_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Break_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Break_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_Repair_2166136261()
		{
		}

		private void RpcLogic___Repair_2166136261()
		{
		}

		private void RpcReader___Observers_Repair_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_DropCash_2166136261()
		{
		}

		private void RpcLogic___DropCash_2166136261()
		{
		}

		private void RpcReader___Server_DropCash_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002EMoney_002EATM_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
