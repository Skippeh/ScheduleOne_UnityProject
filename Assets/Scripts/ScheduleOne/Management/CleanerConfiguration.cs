namespace ScheduleOne.Management
{
	public class CleanerConfiguration : global::ScheduleOne.Management.EntityConfiguration
	{
		public global::ScheduleOne.Management.ObjectField Bed;

		public global::ScheduleOne.Management.ObjectListField Bins;

		public global::ScheduleOne.Employees.Cleaner cleaner { get; protected set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.TrashContainerItem> binItems { get; private set; }

		public global::ScheduleOne.ObjectScripts.BedItem bedItem { get; private set; }

		public CleanerConfiguration(global::ScheduleOne.Management.ConfigurationReplicator replicator, global::ScheduleOne.Management.IConfigurable configurable, global::ScheduleOne.Employees.Cleaner _cleaner)
			: base(null, null)
		{
		}

		public override void Destroy()
		{
		}

		private bool IsObjValid(global::ScheduleOne.EntityFramework.BuildableItem obj, out string reason)
		{
			reason = null;
			return false;
		}

		public void AssignedBinsChanged(global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> objects)
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

		private void BedChanged(global::ScheduleOne.EntityFramework.BuildableItem newItem)
		{
		}
	}
}
