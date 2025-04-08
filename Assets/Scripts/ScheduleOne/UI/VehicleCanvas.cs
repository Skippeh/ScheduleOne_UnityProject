namespace ScheduleOne.UI
{
	public class VehicleCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.VehicleCanvas>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::TMPro.TextMeshProUGUI SpeedText;

		public global::UnityEngine.GameObject DriverPromptsContainer;

		private global::ScheduleOne.Vehicles.LandVehicle currentVehicle;

		protected override void Start()
		{
		}

		private void Subscribe()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void VehicleEntered(global::ScheduleOne.Vehicles.LandVehicle veh)
		{
		}

		private void VehicleExited(global::ScheduleOne.Vehicles.LandVehicle veh, global::UnityEngine.Transform exitPoint)
		{
		}

		private void UpdateSpeedText()
		{
		}
	}
}
