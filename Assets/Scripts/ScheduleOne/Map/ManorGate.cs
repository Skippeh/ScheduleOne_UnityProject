using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Map
{
	public class ManorGate : Gate
	{
		[Header("References")]
		public InteractableObject IntercomInt;

		public Light IntercomLight;

		public VehicleDetector ExteriorVehicleDetector;

		public PlayerDetector ExteriorPlayerDetector;

		public VehicleDetector InteriorVehicleDetector;

		public PlayerDetector InteriorPlayerDetector;

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

		[Button]
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
