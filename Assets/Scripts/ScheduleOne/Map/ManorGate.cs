namespace ScheduleOne.Map
{
	public class ManorGate : global::ScheduleOne.Map.Gate
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntercomInt;

		public global::UnityEngine.Light IntercomLight;

		public global::ScheduleOne.DevUtilities.VehicleDetector ExteriorVehicleDetector;

		public global::ScheduleOne.Tools.PlayerDetector ExteriorPlayerDetector;

		public global::ScheduleOne.DevUtilities.VehicleDetector InteriorVehicleDetector;

		public global::ScheduleOne.Tools.PlayerDetector InteriorPlayerDetector;

		private bool intercomActive;

		protected virtual void Start()
		{
		}

		private void UpdateDetection()
		{
		}

		public void IntercomBuzzed()
		{
		}

		public void SetEnterable(bool enterable)
		{
		}

		[global::EasyButtons.Button]
		public void ActivateIntercom()
		{
		}

		public void SetIntercomActive(bool active)
		{
		}

		private void UpdateIntercom()
		{
		}
	}
}
