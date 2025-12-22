namespace ScheduleOne.Management
{
	public class BotanistConfiguration : global::ScheduleOne.Management.EntityConfiguration
	{
		public static readonly global::System.Type[] AssignableTypes;

		public global::ScheduleOne.Management.ObjectField Home;

		public global::ScheduleOne.Management.ObjectField Supplies;

		public global::ScheduleOne.Management.ObjectListField Assigns;

		private global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> _thisBotanistAssignedOn;

		private global::ScheduleOne.Employees.Botanist _botanist;

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Pot> AssignedPots { get; private set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.DryingRack> AssignedRacks { get; private set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.MushroomBed> AssignedBeds { get; private set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.MushroomSpawnStation> AssignedSpawnStations { get; private set; }

		public global::ScheduleOne.Employees.EmployeeHome AssignedHome { get; private set; }

		public override bool AllowRename()
		{
			return false;
		}

		public BotanistConfiguration(global::ScheduleOne.Management.ConfigurationReplicator replicator, global::ScheduleOne.Management.IConfigurable configurable, global::ScheduleOne.Employees.Botanist _botanist)
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

		public void AssignsChanged(global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> objects)
		{
		}

		private global::ScheduleOne.Management.NPCField GetNPCField(global::ScheduleOne.Management.IConfigurable configurable)
		{
			return null;
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
