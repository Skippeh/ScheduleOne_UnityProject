namespace ScheduleOne.Map
{
	public class AutoshopAccessZone : global::ScheduleOne.Map.NPCPresenceAccessZone
	{
		public global::UnityEngine.Animation RollerDoorAnim;

		public global::ScheduleOne.DevUtilities.VehicleDetector VehicleDetection;

		private bool rollerDoorOpen;

		public override void SetIsOpen(bool open)
		{
		}

		protected override void MinPass()
		{
		}
	}
}
