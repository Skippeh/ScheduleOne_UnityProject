using System;
using System.Collections.Generic;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	public class VendingMachine : NetworkBehaviour, IGUIDRegisterable, IGenericSaveable
	{
		public static List<VendingMachine> AllMachines;

		public const float COST = 2f;

		public const int REPAIR_TIME_DAYS = 2;

		public const float IMPACT_THRESHOLD_FREE_ITEM = 50f;

		public const float IMPACT_THRESHOLD_FREE_ITEM_CHANCE = 0.33f;

		public const float IMPACT_THRESHOLD_BREAK = 165f;

		public const int MIN_CASH_DROP = 1;

		public const int MAX_CASH_DROP = 4;

		[Header("Settings")]
		public int LitStartTime;

		public int LitOnEndTime;

		public ItemPickup CukePrefab;

		public CashPickup CashPrefab;

		[Header("References")]
		public MeshRenderer DoorMesh;

		public MeshRenderer BodyMesh;

		public Material DoorOffMat;

		public Material DoorOnMat;

		public Material BodyOffMat;

		public Material BodyOnMat;

		public OptimizedLight[] Lights;

		public AudioSourceController PaySound;

		public AudioSourceController DispenseSound;

		public Animation Anim;

		public Transform ItemSpawnPoint;

		public InteractableObject IntObj;

		public Transform AccessPoint;

		public PhysicsDamageable Damageable;

		public Transform CashSpawnPoint;

		public UnityEvent onBreak;

		public UnityEvent onRepair;

		private bool isLit;

		private bool purchaseInProgress;

		private float timeOnLastFreeItem;

		[SerializeField]
		protected string BakedGUID;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EVendingMachineAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EVendingMachineAssembly_002DCSharp_002Edll_Excuted;

		public bool IsBroken { get; protected set; }

		public int DaysUntilRepair { get; protected set; }

		public ItemPickup lastDroppedItem { get; protected set; }

		public Guid GUID { get; protected set; }

		[Button]
		public void RegenerateGUID()
		{
		}

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void SetGUID(Guid guid)
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

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPurchase()
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void PurchaseRoutine()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void DropItem()
		{
		}

		public void RemoveLastDropped()
		{
		}

		private void Impacted(Impact impact)
		{
		}

		private void SetLit(bool lit)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendBreak()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void Break(NetworkConnection conn)
		{
		}

		[ObserversRpc]
		private void Repair()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void DropCash()
		{
		}

		public void Load(GenericSaveData data)
		{
		}

		public GenericSaveData GetSaveData()
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

		private void RpcReader___Server_SendPurchase_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PurchaseRoutine_2166136261()
		{
		}

		public void RpcLogic___PurchaseRoutine_2166136261()
		{
		}

		private void RpcReader___Observers_PurchaseRoutine_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_DropItem_2166136261()
		{
		}

		public void RpcLogic___DropItem_2166136261()
		{
		}

		private void RpcReader___Server_DropItem_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendBreak_2166136261()
		{
		}

		private void RpcLogic___SendBreak_2166136261()
		{
		}

		private void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Break_328543758(NetworkConnection conn)
		{
		}

		private void RpcLogic___Break_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_Break_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_Repair_2166136261()
		{
		}

		private void RpcLogic___Repair_2166136261()
		{
		}

		private void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_DropCash_2166136261()
		{
		}

		private void RpcLogic___DropCash_2166136261()
		{
		}

		private void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002EObjectScripts_002EVendingMachine_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
