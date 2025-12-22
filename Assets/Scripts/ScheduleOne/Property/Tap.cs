namespace ScheduleOne.Property
{
	public class Tap : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.Management.IUsable
	{
		private const float FlowRateMultiplier = 6f;

		private const float HandleMoveSpeed = 2f;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Interaction.InteractableObject _interactable;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _handleTransform;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.PlayerTasks.Clickable _handleClickable;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.ParticleSystem _waterParticles;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _squeakSound;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _waterRunningSound;

		private float _normalizedTapFlow;

		private global::UnityEngine.Vector2 _defaultParticleStartSize;

		private float _maxTapOpenValue;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar____003CIsHeldOpen_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EProperty_002ETapAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProperty_002ETapAssembly_002DCSharp_002Edll_Excuted;

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Transform CameraPos { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::UnityEngine.Transform FillableModelContainer { get; private set; }

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

		private void UpdateTapVisuals()
		{
		}

		private void UpdateWaterSound()
		{
		}

		private void Hovered()
		{
		}

		private void Interacted()
		{
		}

		public void SetHandleEnabled(bool enabled)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SetHeldOpen(bool open)
		{
		}

		private void OnHandleClickStart(global::UnityEngine.RaycastHit hit)
		{
		}

		private void OnHandleClickEnd()
		{
		}

		private bool CanInteract(out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public void SetMaxTapOpen(float max)
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

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_SetHeldOpen_1140765316(bool open)
		{
		}

		private void RpcLogic___SetHeldOpen_1140765316(bool open)
		{
		}

		private void RpcReader___Server_SetHeldOpen_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
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

		public virtual bool ReadSyncVar___ScheduleOne_002EProperty_002ETap(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		private void Awake_UserLogic_ScheduleOne_002EProperty_002ETap_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
