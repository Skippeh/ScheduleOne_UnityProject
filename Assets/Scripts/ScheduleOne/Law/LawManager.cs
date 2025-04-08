namespace ScheduleOne.Law
{
	public class LawManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Law.LawManager>
	{
		public const int DISPATCH_OFFICER_COUNT = 2;

		public static float DISPATCH_VEHICLE_USE_THRESHOLD;

		protected override void Start()
		{
		}

		public void PoliceCalled(global::ScheduleOne.PlayerScripts.Player target, global::ScheduleOne.Law.Crime crime)
		{
		}

		public global::ScheduleOne.NPCs.Behaviour.PatrolGroup StartFootpatrol(global::ScheduleOne.NPCs.Behaviour.FootPatrolRoute route, int requestedMembers)
		{
			return null;
		}

		public global::ScheduleOne.Police.PoliceOfficer StartVehiclePatrol(global::ScheduleOne.NPCs.Behaviour.VehiclePatrolRoute route)
		{
			return null;
		}
	}
}
