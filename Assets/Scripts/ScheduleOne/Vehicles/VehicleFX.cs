using UnityEngine;

namespace ScheduleOne.Vehicles
{
	public class VehicleFX : MonoBehaviour
	{
		public ParticleSystem[] exhaustFX;

		public virtual void OnVehicleStart()
		{
		}

		public virtual void OnVehicleStop()
		{
		}
	}
}
