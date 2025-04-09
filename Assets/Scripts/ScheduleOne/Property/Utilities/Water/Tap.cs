using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using ScheduleOne.Management;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Property.Utilities.Water
{
	public class Tap : NetworkBehaviour, IUsable
	{
		public const float MaxFlowRate = 6f;

		[Header("References")]
		public InteractableObject IntObj;

		public Transform CameraPos;

		public Transform WateringCamPos;

		public Collider HandleCollider;

		public Transform Handle;

		public Clickable HandleClickable;

		public ParticleSystem WaterParticles;

		public AudioSourceController SqueakSound;

		public AudioSourceController WaterRunningSound;

		private float tapFlow;

		private GameObject wateringCanModel;

		private bool intObjSetThisFrame;

		public SyncVar<bool> syncVar____003CIsHeldOpen_003Ek__BackingField;

		public SyncVar<NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public SyncVar<NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EProperty_002EUtilities_002EWater_002ETapAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProperty_002EUtilities_002EWater_002ETapAssembly_002DCSharp_002Edll_Excuted;

		[field: SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public bool IsHeldOpen { get; set; }

		public float ActualFlowRate => 0f;

		[field: SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public NetworkObject NPCUserObject { get; set; }

		[field: SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public NetworkObject PlayerUserObject { get; set; }

		public bool SyncAccessor__003CIsHeldOpen_003Ek__BackingField
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public NetworkObject SyncAccessor__003CNPCUserObject_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NetworkObject SyncAccessor__003CPlayerUserObject_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void SetInteractableObject(string message, InteractableObject.EInteractableState state)
		{
		}

		protected void UpdateTapVisuals()
		{
		}

		protected void UpdateWaterSound()
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetHeldOpen(bool open)
		{
		}

		protected virtual bool CanInteract()
		{
			return false;
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendWateringCanModel(string ID)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void CreateWateringCanModel(string ID)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendClearWateringCanModelModel()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void ClearWateringCanModel()
		{
		}

		public GameObject CreateWateringCanModel_Local(string ID, bool force = false)
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

		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetHeldOpen_1140765316(bool open)
		{
		}

		public void RpcLogic___SetHeldOpen_1140765316(bool open)
		{
		}

		private void RpcReader___Server_SetHeldOpen_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendWateringCanModel_3615296227(string ID)
		{
		}

		public void RpcLogic___SendWateringCanModel_3615296227(string ID)
		{
		}

		private void RpcReader___Server_SendWateringCanModel_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_CreateWateringCanModel_3615296227(string ID)
		{
		}

		private void RpcLogic___CreateWateringCanModel_3615296227(string ID)
		{
		}

		private void RpcReader___Observers_CreateWateringCanModel_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendClearWateringCanModelModel_2166136261()
		{
		}

		public void RpcLogic___SendClearWateringCanModelModel_2166136261()
		{
		}

		private void RpcReader___Server_SendClearWateringCanModelModel_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ClearWateringCanModel_2166136261()
		{
		}

		private void RpcLogic___ClearWateringCanModel_2166136261()
		{
		}

		private void RpcReader___Observers_ClearWateringCanModel_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EProperty_002EUtilities_002EWater_002ETap(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		private void Awake_UserLogic_ScheduleOne_002EProperty_002EUtilities_002EWater_002ETap_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
