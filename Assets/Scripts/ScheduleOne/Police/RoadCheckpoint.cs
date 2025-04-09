using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Misc;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Police
{
	public class RoadCheckpoint : NetworkBehaviour
	{
		public enum ECheckpointState
		{
			Disabled = 0,
			Enabled = 1
		}

		public const float MAX_TIME_OPEN = 15f;

		protected ECheckpointState appliedState;

		public List<NPC> AssignedNPCs;

		[Header("Settings")]
		public EStealthLevel MaxStealthLevel;

		public bool OpenForNPCs;

		public bool EnabledOnStart;

		[Header("References")]
		[SerializeField]
		protected GameObject container;

		public CarStopper Stopper1;

		public CarStopper Stopper2;

		public VehicleDetector SearchArea1;

		public VehicleDetector SearchArea2;

		public VehicleObstacle VehicleObstacle1;

		public VehicleObstacle VehicleObstacle2;

		public VehicleDetector NPCVehicleDetectionArea1;

		public VehicleDetector NPCVehicleDetectionArea2;

		public VehicleDetector ImmediateVehicleDetector;

		public Rigidbody[] TrafficCones;

		public Transform[] StandPoints;

		protected Dictionary<Rigidbody, Tuple<Vector3, Quaternion>> trafficConeOriginalTransforms;

		private float timeSinceGate1Open;

		private bool vehicleDetectedSinceGate1Open;

		private float timeSinceGate2Open;

		private bool vehicleDetectedSinceGate2Open;

		public UnityEvent<Player> onPlayerWalkThrough;

		public SyncVar<bool> syncVar____003CGate1Open_003Ek__BackingField;

		public SyncVar<bool> syncVar____003CGate2Open_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EPolice_002ERoadCheckpointAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EPolice_002ERoadCheckpointAssembly_002DCSharp_002Edll_Excuted;

		public ECheckpointState ActivationState { get; protected set; }

		[field: SyncVar(SendRate = 0.25f)]
		public bool Gate1Open { get; protected set; }

		[field: SyncVar(SendRate = 0.25f)]
		public bool Gate2Open { get; protected set; }

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

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void Enable(NetworkConnection conn)
		{
		}

		[ObserversRpc(RunLocally = true)]
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

		public void PlayerDetected(Player player)
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

		private void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
		}

		public void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_Disable_2166136261()
		{
		}

		public void RpcLogic___Disable_2166136261()
		{
		}

		private void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EPolice_002ERoadCheckpoint(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EPolice_002ERoadCheckpoint_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
