namespace ScheduleOne.Vehicles.Modification
{
	public class VehicleModStation : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform vehiclePosition;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.DevUtilities.OrbitCamera orbitCam;

		public global::ScheduleOne.Vehicles.LandVehicle currentVehicle { get; protected set; }

		public bool isOpen => false;

		public void Open(global::ScheduleOne.Vehicles.LandVehicle vehicle)
		{
		}

		protected virtual void Update()
		{
		}

		public void Close()
		{
		}
	}
}
