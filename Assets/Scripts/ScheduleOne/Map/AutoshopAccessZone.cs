using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Map
{
	public class AutoshopAccessZone : NPCPresenceAccessZone
	{
		public Animation RollerDoorAnim;

		public VehicleDetector VehicleDetection;

		private bool rollerDoorOpen;

		public override void SetIsOpen(bool open)
		{
		}

		protected override void MinPass()
		{
		}
	}
}
