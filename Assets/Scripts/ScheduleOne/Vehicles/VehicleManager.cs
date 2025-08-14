namespace ScheduleOne.Vehicles
{
	public class VehicleManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Vehicles.VehicleManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.LandVehicle> AllVehicles;

		[global::UnityEngine.Header("Vehicles")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.LandVehicle> VehiclePrefabs;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.LandVehicle> PlayerOwnedVehicles;

		private global::ScheduleOne.Persistence.Loaders.VehiclesLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002EVehicleManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002EVehicleManagerAssembly_002DCSharp_002Edll_Excuted;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		public override void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SpawnVehicle(string vehicleCode, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, bool playerOwned)
		{
		}

		public global::ScheduleOne.Vehicles.LandVehicle SpawnAndReturnVehicle(string vehicleCode, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, bool playerOwned)
		{
			return null;
		}

		public global::ScheduleOne.Vehicles.LandVehicle GetVehiclePrefab(string vehicleCode)
		{
			return null;
		}

		public global::ScheduleOne.Vehicles.LandVehicle SpawnAndLoadVehicle(global::ScheduleOne.Persistence.Datas.VehicleData data, string path, bool playerOwned)
		{
			return null;
		}

		public void LoadVehicle(global::ScheduleOne.Persistence.Datas.VehicleData data, string path)
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public void SpawnLoanSharkVehicle(global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rot)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void EnableLoanSharkVisuals(global::FishNet.Object.NetworkObject veh)
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_SpawnVehicle_3323115898(string vehicleCode, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, bool playerOwned)
		{
		}

		public void RpcLogic___SpawnVehicle_3323115898(string vehicleCode, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, bool playerOwned)
		{
		}

		private void RpcReader___Server_SpawnVehicle_3323115898(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_EnableLoanSharkVisuals_3323014238(global::FishNet.Object.NetworkObject veh)
		{
		}

		private void RpcLogic___EnableLoanSharkVisuals_3323014238(global::FishNet.Object.NetworkObject veh)
		{
		}

		private void RpcReader___Observers_EnableLoanSharkVisuals_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVehicles_002EVehicleManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
