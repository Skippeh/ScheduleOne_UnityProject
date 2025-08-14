namespace ScheduleOne.Vehicles
{
	public class VehicleLights : global::FishNet.Object.NetworkBehaviour
	{
		private const int brakeHistoryMaxCount = 60;

		public global::ScheduleOne.Vehicles.LandVehicle vehicle;

		[global::UnityEngine.Header("Headlights")]
		public bool hasHeadLights;

		public global::UnityEngine.MeshRenderer[] headLightMeshes;

		public global::ScheduleOne.DevUtilities.OptimizedLight[] headLightSources;

		public global::UnityEngine.Material headlightMat_On;

		public global::UnityEngine.Material headLightMat_Off;

		protected bool headLightsApplied;

		[global::UnityEngine.Header("Brake lights")]
		public bool hasBrakeLights;

		public global::UnityEngine.MeshRenderer[] brakeLightMeshes;

		public global::UnityEngine.Light[] brakeLightSources;

		public global::UnityEngine.Material brakeLightMat_On;

		public global::UnityEngine.Material brakeLightMat_Off;

		public global::UnityEngine.Material brakeLightMat_Ambient;

		protected bool brakeLightsOn;

		protected bool brakeLightsApplied;

		[global::UnityEngine.Header("Reverse lights")]
		public bool hasReverseLights;

		public global::UnityEngine.MeshRenderer[] reverseLightMeshes;

		public global::UnityEngine.Light[] reverseLightSources;

		public global::UnityEngine.Material reverseLightMat_On;

		public global::UnityEngine.Material reverseLightMat_Off;

		protected bool reverseLightsOn;

		protected bool reverseLightsApplied;

		public global::UnityEngine.Events.UnityEvent onHeadlightsOn;

		public global::UnityEngine.Events.UnityEvent onHeadlightsOff;

		private CircularQueue<bool> brakesAppliedHistory;

		private global::ScheduleOne.Vehicles.AI.VehicleAgent agent;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar____003CheadLightsOn_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002EVehicleLightsAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002EVehicleLightsAssembly_002DCSharp_002Edll_Excuted;

		public bool headLightsOn
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return false;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
			set
			{
			}
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

		[global::System.Runtime.CompilerServices.SpecialName]
		public void RpcLogic___set_headLightsOn_1140765316(bool value)
		{
		}

		private void RpcReader___Server_set_headLightsOn_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EVehicles_002EVehicleLights(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVehicles_002EVehicleLights_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
