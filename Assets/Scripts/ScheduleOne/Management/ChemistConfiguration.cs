namespace ScheduleOne.Management
{
	public class ChemistConfiguration : global::ScheduleOne.Management.EntityConfiguration
	{
		public global::ScheduleOne.Management.ObjectField Home;

		public global::ScheduleOne.Management.ObjectListField Stations;

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.ChemistryStation> ChemStations;

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.LabOven> LabOvens;

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.Cauldron> Cauldrons;

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.MixingStation> MixStations;

		public int TotalStations => 0;

		public global::ScheduleOne.Employees.Chemist chemist { get; protected set; }

		public global::ScheduleOne.Employees.EmployeeHome assignedHome { get; private set; }

		public override bool AllowRename()
		{
			return false;
		}

		public ChemistConfiguration(global::ScheduleOne.Management.ConfigurationReplicator replicator, global::ScheduleOne.Management.IConfigurable configurable, global::ScheduleOne.Employees.Chemist _chemist)
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
