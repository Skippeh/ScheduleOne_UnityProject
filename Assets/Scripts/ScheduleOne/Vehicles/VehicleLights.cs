namespace ScheduleOne.Vehicles
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Vehicles.LandVehicle))]
	public class VehicleLights : global::FishNet.Object.NetworkBehaviour
	{
		[global::UnityEngine.SerializeField]
		private bool _debug;

		[global::UnityEngine.Header("Headlights")]
		public global::UnityEngine.MeshRenderer[] headLightMeshes;

		public global::ScheduleOne.DevUtilities.OptimizedLight[] headLightSources;

		public global::UnityEngine.Material headlightMat_On;

		public global::UnityEngine.Material headLightMat_Off;

		private bool headLightsApplied;

		[global::UnityEngine.Header("Brake lights")]
		public global::UnityEngine.MeshRenderer[] brakeLightMeshes;

		public global::UnityEngine.Light[] brakeLightSources;

		public global::UnityEngine.Material brakeLightMat_On;

		public global::UnityEngine.Material brakeLightMat_Off;

		private bool brakeLightsApplied;

		[global::UnityEngine.Header("Reverse lights")]
		public bool hasReverseLights;

		public global::UnityEngine.MeshRenderer[] reverseLightMeshes;

		public global::UnityEngine.Light[] reverseLightSources;

		public global::UnityEngine.Material reverseLightMat_On;

		public global::UnityEngine.Material reverseLightMat_Off;

		private bool reverseLightsApplied;

		private global::ScheduleOne.Vehicles.LandVehicle vehicle;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar____003CHeadlightsOn_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002EVehicleLightsAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002EVehicleLightsAssembly_002DCSharp_002Edll_Excuted;

		public bool HeadlightsOn
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

		public bool SyncAccessor__003CHeadlightsOn_003Ek__BackingField
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

		private void UpdateVisuals()
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

		private void RpcWriter___Server_set_HeadlightsOn_1140765316(bool value)
		{
		}

		[global::System.Runtime.CompilerServices.SpecialName]
		public void RpcLogic___set_HeadlightsOn_1140765316(bool value)
		{
		}

		private void RpcReader___Server_set_HeadlightsOn_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EVehicles_002EVehicleLights(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		private void Awake_UserLogic_ScheduleOne_002EVehicles_002EVehicleLights_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
