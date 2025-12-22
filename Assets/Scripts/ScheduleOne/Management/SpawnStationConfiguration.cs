namespace ScheduleOne.Management
{
	public class SpawnStationConfiguration : global::ScheduleOne.Management.EntityConfiguration
	{
		public global::ScheduleOne.Management.NPCField AssignedBotanist;

		public global::ScheduleOne.Management.ObjectField Destination;

		public global::ScheduleOne.StationFramework.MushroomSpawnStation Station { get; protected set; }

		public global::ScheduleOne.Management.TransitRoute DestinationRoute { get; protected set; }

		public SpawnStationConfiguration(global::ScheduleOne.Management.ConfigurationReplicator replicator, global::ScheduleOne.Management.IConfigurable configurable, global::ScheduleOne.StationFramework.MushroomSpawnStation station)
			: base(null, null, null)
		{
		}

		public override void Reset()
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
