using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Vehicles.Modification
{
	public class VehicleModStation : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		protected Transform vehiclePosition;

		[SerializeField]
		protected OrbitCamera orbitCam;

		public LandVehicle currentVehicle { get; protected set; }

		public bool isOpen => false;

		public void Open(LandVehicle vehicle)
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
