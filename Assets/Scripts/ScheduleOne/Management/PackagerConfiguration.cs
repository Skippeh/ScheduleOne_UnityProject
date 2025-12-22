namespace ScheduleOne.Management
{
	public class PackagerConfiguration : global::ScheduleOne.Management.EntityConfiguration
	{
		public global::ScheduleOne.Management.ObjectField Home;

		public global::ScheduleOne.Management.ObjectListField Stations;

		public global::ScheduleOne.Management.RouteListField Routes;

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.PackagingStation> AssignedStations;

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.BrickPress> AssignedBrickPresses;

		public int AssignedStationCount => 0;

		public global::ScheduleOne.Employees.Packager packager { get; protected set; }

		public global::ScheduleOne.Employees.EmployeeHome assignedHome { get; private set; }

		public override bool AllowRename()
		{
			return false;
		}

		public PackagerConfiguration(global::ScheduleOne.Management.ConfigurationReplicator replicator, global::ScheduleOne.Management.IConfigurable configurable, global::ScheduleOne.Employees.Packager _packager)
			: base(null, null, null)
		{
		}

		public override void Reset()
		{
		}

		private bool IsStationValid(global::ScheduleOne.EntityFramework.BuildableItem obj, out string reason)
		{
			reason = null;
			return false;
		}

		public void AssignedStationsChanged(global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> objects)
		{
		}

		public override bool ShouldSave()
		{
			return false;
		}

		public override string GetSaveString()
		{
			return null;
		}

		private void HomeChanged(global::ScheduleOne.EntityFramework.BuildableItem newItem)
		{
		}
	}
}
