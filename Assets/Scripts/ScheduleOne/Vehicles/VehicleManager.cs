using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	public class VehicleManager : NetworkSingleton<VehicleManager>, IBaseSaveable, ISaveable
	{
		public List<LandVehicle> AllVehicles;

		[Header("Vehicles")]
		public List<LandVehicle> VehiclePrefabs;

		public List<LandVehicle> PlayerOwnedVehicles;

		private VehiclesLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002EVehicleManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002EVehicleManagerAssembly_002DCSharp_002Edll_Excuted;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public override void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SpawnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
		}

		public LandVehicle SpawnAndReturnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			return null;
		}

		public LandVehicle GetVehiclePrefab(string vehicleCode)
		{
			return null;
		}

		public LandVehicle SpawnAndLoadVehicle(VehicleData data, string path, bool playerOwned)
		{
			return null;
		}

		public void LoadVehicle(VehicleData data, string path)
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public void SpawnLoanSharkVehicle(Vector3 position, Quaternion rot)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void EnableLoanSharkVisuals(NetworkObject veh)
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

		private void RpcWriter___Server_SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
		}

		public void RpcLogic___SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
		}

		private void RpcReader___Server_SpawnVehicle_3323115898(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_EnableLoanSharkVisuals_3323014238(NetworkObject veh)
		{
		}

		private void RpcLogic___EnableLoanSharkVisuals_3323014238(NetworkObject veh)
		{
		}

		private void RpcReader___Observers_EnableLoanSharkVisuals_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVehicles_002EVehicleManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
