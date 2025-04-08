namespace ScheduleOne.Vehicles
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Vehicles.LandVehicle))]
	public class VehicleInitializer : global::FishNet.Object.NetworkBehaviour
	{
		public global::ScheduleOne.Map.ParkingLot InitialParkingLot;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002EVehicleInitializerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002EVehicleInitializerAssembly_002DCSharp_002Edll_Excuted;

		public override void OnStartServer()
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

		public virtual void Awake()
		{
		}
	}
}
