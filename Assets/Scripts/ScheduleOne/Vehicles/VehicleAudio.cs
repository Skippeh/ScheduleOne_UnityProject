namespace ScheduleOne.Vehicles
{
	public class VehicleAudio : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Refererences")]
		public global::ScheduleOne.Vehicles.LandVehicle Vehicle;

		public global::ScheduleOne.Vehicles.VehicleLights Lights;

		[global::UnityEngine.Header("Sounds")]
		public global::UnityEngine.AudioSource EngineStartSound;

		public global::UnityEngine.AudioSource EngineStopSound;

		public global::UnityEngine.AudioSource HeadlightsOnSound;

		public global::UnityEngine.AudioSource HeadlightsOffSound;

		public global::UnityEngine.AudioSource HornSound;

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
