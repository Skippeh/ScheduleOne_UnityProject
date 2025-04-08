namespace ScheduleOne.Property.Utilities.Water
{
	public class Tap : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.Management.IUsable
	{
		public const float MaxFlowRate = 6f;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform CameraPos;

		public global::UnityEngine.Transform WateringCamPos;

		public global::UnityEngine.Collider HandleCollider;

		public global::UnityEngine.Transform Handle;

		public global::ScheduleOne.PlayerTasks.Clickable HandleClickable;

		public global::UnityEngine.ParticleSystem WaterParticles;

		public global::ScheduleOne.Audio.AudioSourceController SqueakSound;

		public global::ScheduleOne.Audio.AudioSourceController WaterRunningSound;

		private float tapFlow;

		private global::UnityEngine.GameObject wateringCanModel;

		private bool intObjSetThisFrame;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar____003CIsHeldOpen_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EProperty_002EUtilities_002EWater_002ETapAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProperty_002EUtilities_002EWater_002ETapAssembly_002DCSharp_002Edll_Excuted;

		public bool IsHeldOpen
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return false;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		public float ActualFlowRate => 0f;

		public global::FishNet.Object.NetworkObject NPCUserObject
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		public global::FishNet.Object.NetworkObject PlayerUserObject
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

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

		public global::FishNet.Object.NetworkObject SyncAccessor__003CNPCUserObject_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::FishNet.Object.NetworkObject SyncAccessor__003CPlayerUserObject_003Ek__BackingField
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

		public void SetInteractableObject(string message, global::ScheduleOne.Interaction.InteractableObject.EInteractableState state)
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

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(global::FishNet.Object.NetworkObject npcObject)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetHeldOpen(bool open)
		{
		}

		protected virtual bool CanInteract()
		{
			return false;
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendWateringCanModel(string ID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void CreateWateringCanModel(string ID)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendClearWateringCanModelModel()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ClearWateringCanModel()
		{
		}

		public global::UnityEngine.GameObject CreateWateringCanModel_Local(string ID, bool force = false)
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

		private void RpcWriter___Server_SetPlayerUser_3323014238(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		public void RpcLogic___SetPlayerUser_3323014238(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		private void RpcReader___Server_SetPlayerUser_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetNPCUser_3323014238(global::FishNet.Object.NetworkObject npcObject)
		{
		}

		public void RpcLogic___SetNPCUser_3323014238(global::FishNet.Object.NetworkObject npcObject)
		{
		}

		private void RpcReader___Server_SetNPCUser_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetHeldOpen_1140765316(bool open)
		{
		}

		public void RpcLogic___SetHeldOpen_1140765316(bool open)
		{
		}

		private void RpcReader___Server_SetHeldOpen_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendWateringCanModel_3615296227(string ID)
		{
		}

		public void RpcLogic___SendWateringCanModel_3615296227(string ID)
		{
		}

		private void RpcReader___Server_SendWateringCanModel_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_CreateWateringCanModel_3615296227(string ID)
		{
		}

		private void RpcLogic___CreateWateringCanModel_3615296227(string ID)
		{
		}

		private void RpcReader___Observers_CreateWateringCanModel_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendClearWateringCanModelModel_2166136261()
		{
		}

		public void RpcLogic___SendClearWateringCanModelModel_2166136261()
		{
		}

		private void RpcReader___Server_SendClearWateringCanModelModel_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ClearWateringCanModel_2166136261()
		{
		}

		private void RpcLogic___ClearWateringCanModel_2166136261()
		{
		}

		private void RpcReader___Observers_ClearWateringCanModel_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EProperty_002EUtilities_002EWater_002ETap(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		private void Awake_UserLogic_ScheduleOne_002EProperty_002EUtilities_002EWater_002ETap_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
