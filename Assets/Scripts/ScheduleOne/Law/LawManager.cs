using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;

namespace ScheduleOne.Law
{
	public class LawManager : Singleton<LawManager>
	{
		public const int DISPATCH_OFFICER_COUNT = 2;

		public static float DISPATCH_VEHICLE_USE_THRESHOLD;

		protected override void Start()
		{
		}

		public void PoliceCalled(Player target, Crime crime)
		{
		}

		public PatrolGroup StartFootpatrol(FootPatrolRoute route, int requestedMembers)
		{
			return null;
		}

		public PoliceOfficer StartVehiclePatrol(VehiclePatrolRoute route)
		{
			return null;
		}
	}
}
