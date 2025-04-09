using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles.AI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Vehicles
{
	public class VehicleLights : NetworkBehaviour
	{
		public LandVehicle vehicle;

		[Header("Headlights")]
		public bool hasHeadLights;

		public MeshRenderer[] headLightMeshes;

		public OptimizedLight[] headLightSources;

		public Material headlightMat_On;

		public Material headLightMat_Off;

		protected bool headLightsApplied;

		[Header("Brake lights")]
		public bool hasBrakeLights;

		public MeshRenderer[] brakeLightMeshes;

		public Light[] brakeLightSources;

		public Material brakeLightMat_On;

		public Material brakeLightMat_Off;

		public Material brakeLightMat_Ambient;

		protected bool brakeLightsOn;

		protected bool brakeLightsApplied;

		[Header("Reverse lights")]
		public bool hasReverseLights;

		public MeshRenderer[] reverseLightMeshes;

		public Light[] reverseLightSources;

		public Material reverseLightMat_On;

		public Material reverseLightMat_Off;

		protected bool reverseLightsOn;

		protected bool reverseLightsApplied;

		public UnityEvent onHeadlightsOn;

		public UnityEvent onHeadlightsOff;

		private List<bool> brakesAppliedHistory;

		private VehicleAgent agent;

		public SyncVar<bool> syncVar____003CheadLightsOn_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002EVehicleLightsAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002EVehicleLightsAssembly_002DCSharp_002Edll_Excuted;

		[field: SyncVar(Channel = Channel.Unreliable, SendRate = 0.25f, WritePermissions = WritePermission.ClientUnsynchronized)]
		public bool headLightsOn
		{
			get; [ServerRpc(RunLocally = true, RequireOwnership = false)]
			set;
		}

		public bool SyncAccessor__003CheadLightsOn_003Ek__BackingField
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

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void LateUpdate()
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

		private void RpcWriter___Server_set_headLightsOn_1140765316(bool value)
		{
		}

		[SpecialName]
		public void RpcLogic___set_headLightsOn_1140765316(bool value)
		{
		}

		private void RpcReader___Server_set_headLightsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EVehicles_002EVehicleLights(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVehicles_002EVehicleLights_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
