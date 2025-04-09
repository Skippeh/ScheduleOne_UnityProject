using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class VehicleCanvas : Singleton<VehicleCanvas>
	{
		[Header("References")]
		public Canvas Canvas;

		public TextMeshProUGUI SpeedText;

		public GameObject DriverPromptsContainer;

		private LandVehicle currentVehicle;

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

		private void VehicleEntered(LandVehicle veh)
		{
		}

		private void VehicleExited(LandVehicle veh, Transform exitPoint)
		{
		}

		private void UpdateSpeedText()
		{
		}
	}
}
