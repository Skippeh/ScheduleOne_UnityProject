using UnityEngine;

namespace ScheduleOne.Vehicles
{
	public class VehicleAudio : MonoBehaviour
	{
		[Header("Refererences")]
		public LandVehicle Vehicle;

		public VehicleLights Lights;

		[Header("Sounds")]
		public AudioSource EngineStartSound;

		public AudioSource EngineStopSound;

		public AudioSource HeadlightsOnSound;

		public AudioSource HeadlightsOffSound;

		public AudioSource HornSound;

		protected virtual void Awake()
		{
		}

		protected virtual void EngineStart()
		{
		}

		protected virtual void EngineStop()
		{
		}

		protected virtual void HeadlightsToggledOn()
		{
		}

		protected virtual void HeadlightsToggledOff()
		{
		}
	}
}
