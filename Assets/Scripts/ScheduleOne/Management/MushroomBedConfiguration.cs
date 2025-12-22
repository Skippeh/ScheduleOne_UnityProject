namespace ScheduleOne.Management
{
	public class MushroomBedConfiguration : global::ScheduleOne.Management.EntityConfiguration
	{
		public global::ScheduleOne.Management.ItemField Spawn;

		public global::ScheduleOne.Management.ItemField Additive1;

		public global::ScheduleOne.Management.ItemField Additive2;

		public global::ScheduleOne.Management.ItemField Additive3;

		public global::ScheduleOne.Management.NPCField AssignedBotanist;

		public global::ScheduleOne.Management.ObjectField Destination;

		public global::ScheduleOne.ObjectScripts.MushroomBed MushroomBed { get; protected set; }

		public global::ScheduleOne.Management.TransitRoute DestinationRoute { get; protected set; }

		public MushroomBedConfiguration(global::ScheduleOne.Management.ConfigurationReplicator replicator, global::ScheduleOne.Management.IConfigurable configurable, global::ScheduleOne.ObjectScripts.MushroomBed mushroomBed)
			: base(null, null, null)
		{
		}

		public string[] GetSelectedSeedIDs()
		{
			return null;
		}

		public bool IsAdditiveSelected(global::ScheduleOne.ItemFramework.ItemDefinition additive)
		{
			return false;
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
