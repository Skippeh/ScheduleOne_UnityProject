namespace ScheduleOne.ObjectScripts
{
	public class VendingMachine : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.IGUIDRegisterable, global::ScheduleOne.Persistence.IGenericSaveable
	{
		public static global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.VendingMachine> AllMachines;

		public const float COST = 2f;

		public const int REPAIR_TIME_DAYS = 0;

		public const float IMPACT_THRESHOLD_FREE_ITEM = 50f;

		public const float IMPACT_THRESHOLD_FREE_ITEM_CHANCE = 0.33f;

		public const float IMPACT_THRESHOLD_BREAK = 165f;

		public const int MIN_CASH_DROP = 1;

		public const int MAX_CASH_DROP = 4;

		[global::UnityEngine.Header("Settings")]
		public int LitStartTime;

		public int LitOnEndTime;

		public global::ScheduleOne.ItemFramework.NetworkedItemPickup CukePrefab;

		public global::ScheduleOne.ItemFramework.CashPickup CashPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.MeshRenderer DoorMesh;

		public global::UnityEngine.MeshRenderer BodyMesh;

		public global::UnityEngine.Material DoorOffMat;

		public global::UnityEngine.Material DoorOnMat;

		public global::UnityEngine.Material BodyOffMat;

		public global::UnityEngine.Material BodyOnMat;

		public global::ScheduleOne.DevUtilities.OptimizedLight[] Lights;

		public global::ScheduleOne.Audio.AudioSourceController PaySound;

		public global::ScheduleOne.Audio.AudioSourceController DispenseSound;

		public global::UnityEngine.Animation Anim;

		public global::UnityEngine.Transform ItemSpawnPoint;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform AccessPoint;

		public global::ScheduleOne.Combat.PhysicsDamageable Damageable;

		public global::UnityEngine.Transform CashSpawnPoint;

		public global::UnityEngine.Events.UnityEvent onBreak;

		public global::UnityEngine.Events.UnityEvent onRepair;

		private bool isLit;

		private bool purchaseInProgress;

		private float timeOnLastFreeItem;

		[global::UnityEngine.SerializeField]
		protected string BakedGUID;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EVendingMachineAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EVendingMachineAssembly_002DCSharp_002Edll_Excuted;

		public bool IsBroken { get; protected set; }

		public int DaysUntilRepair { get; protected set; }

		public global::ScheduleOne.ItemFramework.NetworkedItemPickup lastDroppedItem { get; protected set; }

		public global::System.Guid GUID { get; protected set; }

		[global::EasyButtons.Button]
		public void RegenerateGUID()
		{
		}

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		private void OnDestroy()
		{
		}

		private void MinPass()
		{
		}

		public void DayPass()
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private void LocalPurchase()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPurchase()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void PurchaseRoutine()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void DropItem()
		{
		}

		public void RemoveLastDropped()
		{
		}

		private void Impacted(global::ScheduleOne.Combat.Impact impact)
		{
		}

		private void SetLit(bool lit)
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

		private void RpcWriter___Server_SendPurchase_2166136261()
		{
		}

		public void RpcLogic___SendPurchase_2166136261()
		{
		}

		private void RpcReader___Server_SendPurchase_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PurchaseRoutine_2166136261()
		{
		}

		public void RpcLogic___PurchaseRoutine_2166136261()
		{
		}

		private void RpcReader___Observers_PurchaseRoutine_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_DropItem_2166136261()
		{
		}

		public void RpcLogic___DropItem_2166136261()
		{
		}

		private void RpcReader___Server_DropItem_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
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

		private void Awake_UserLogic_ScheduleOne_002EObjectScripts_002EVendingMachine_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
