namespace ScheduleOne.Police
{
	public class RoadCheckpoint : global::FishNet.Object.NetworkBehaviour
	{
		public enum ECheckpointState
		{
			Disabled = 0,
			Enabled = 1
		}

		public const float MAX_TIME_OPEN = 15f;

		protected global::ScheduleOne.Police.RoadCheckpoint.ECheckpointState appliedState;

		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> AssignedNPCs;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.Product.Packaging.EStealthLevel MaxStealthLevel;

		public bool OpenForNPCs;

		public bool EnabledOnStart;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject container;

		public global::ScheduleOne.Misc.CarStopper Stopper1;

		public global::ScheduleOne.Misc.CarStopper Stopper2;

		public global::ScheduleOne.DevUtilities.VehicleDetector SearchArea1;

		public global::ScheduleOne.DevUtilities.VehicleDetector SearchArea2;

		public global::ScheduleOne.Vehicles.VehicleObstacle VehicleObstacle1;

		public global::ScheduleOne.Vehicles.VehicleObstacle VehicleObstacle2;

		public global::ScheduleOne.DevUtilities.VehicleDetector NPCVehicleDetectionArea1;

		public global::ScheduleOne.DevUtilities.VehicleDetector NPCVehicleDetectionArea2;

		public global::ScheduleOne.DevUtilities.VehicleDetector ImmediateVehicleDetector;

		public global::UnityEngine.Rigidbody[] TrafficCones;

		public global::UnityEngine.Transform[] StandPoints;

		protected global::System.Collections.Generic.Dictionary<global::UnityEngine.Rigidbody, global::System.Tuple<global::UnityEngine.Vector3, global::UnityEngine.Quaternion>> trafficConeOriginalTransforms;

		private float timeSinceGate1Open;

		private bool vehicleDetectedSinceGate1Open;

		private float timeSinceGate2Open;

		private bool vehicleDetectedSinceGate2Open;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.PlayerScripts.Player> onPlayerWalkThrough;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar____003CGate1Open_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar____003CGate2Open_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EPolice_002ERoadCheckpointAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EPolice_002ERoadCheckpointAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Police.RoadCheckpoint.ECheckpointState ActivationState { get; protected set; }

		public bool Gate1Open
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return false;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
			}
		}

		public bool Gate2Open
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return false;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
			}
		}

		public bool SyncAccessor__003CGate1Open_003Ek__BackingField
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SyncAccessor__003CGate2Open_003Ek__BackingField
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void ApplyState()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void Enable(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void Disable()
		{
		}

		public void SetGate1Open(bool o)
		{
		}

		public void SetGate2Open(bool o)
		{
		}

		private void ResetTrafficCones()
		{
		}

		public void PlayerDetected(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		private bool TryGetNearestAssignedNPC(out global::ScheduleOne.NPCs.NPC npc, out float distance)
		{
			npc = null;
			distance = default(float);
			return false;
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

		private void RpcWriter___Observers_Enable_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public void RpcLogic___Enable_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Enable_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Enable_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Enable_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_Disable_2166136261()
		{
		}

		public void RpcLogic___Disable_2166136261()
		{
		}

		private void RpcReader___Observers_Disable_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EPolice_002ERoadCheckpoint(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EPolice_002ERoadCheckpoint_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
