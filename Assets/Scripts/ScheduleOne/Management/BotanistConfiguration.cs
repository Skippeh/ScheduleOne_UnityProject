namespace ScheduleOne.Management
{
	public class BotanistConfiguration : global::ScheduleOne.Management.EntityConfiguration
	{
		public global::ScheduleOne.Management.ObjectField Home;

		public global::ScheduleOne.Management.ObjectField Supplies;

		public global::ScheduleOne.Management.ObjectListField AssignedStations;

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Pot> AssignedPots;

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.DryingRack> AssignedRacks;

		public global::ScheduleOne.Employees.Botanist botanist { get; protected set; }

		public global::ScheduleOne.Employees.EmployeeHome assignedHome { get; private set; }

		public BotanistConfiguration(global::ScheduleOne.Management.ConfigurationReplicator replicator, global::ScheduleOne.Management.IConfigurable configurable, global::ScheduleOne.Employees.Botanist _botanist)
			: base(null, null)
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

		public void AssignedPotsChanged(global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> objects)
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
