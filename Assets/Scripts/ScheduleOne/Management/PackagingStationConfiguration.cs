namespace ScheduleOne.Management
{
	public class PackagingStationConfiguration : global::ScheduleOne.Management.EntityConfiguration
	{
		public global::ScheduleOne.Management.NPCField AssignedPackager;

		public global::ScheduleOne.Management.ObjectField Destination;

		public global::ScheduleOne.ObjectScripts.PackagingStation Station { get; protected set; }

		public global::ScheduleOne.Management.TransitRoute DestinationRoute { get; protected set; }

		public PackagingStationConfiguration(global::ScheduleOne.Management.ConfigurationReplicator replicator, global::ScheduleOne.Management.IConfigurable configurable, global::ScheduleOne.ObjectScripts.PackagingStation station)
			: base(null, null)
		{
		}

		public override void Destroy()
		{
		}

		private void DestinationChanged(global::ScheduleOne.EntityFramework.BuildableItem item)
		{
		}

		public bool DestinationFilter(global::ScheduleOne.EntityFramework.BuildableItem obj, out string reason)
		{
			reason = null;
			return false;
		}

		public override void Selected()
		{
		}

		public override void Deselected()
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
	}
}
