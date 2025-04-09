using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	public class PotConfiguration : EntityConfiguration
	{
		public ItemField Seed;

		public ItemField Additive1;

		public ItemField Additive2;

		public ItemField Additive3;

		public NPCField AssignedBotanist;

		public ObjectField Destination;

		public Pot Pot { get; protected set; }

		public TransitRoute DestinationRoute { get; protected set; }

		public PotConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Pot pot)
			: base(null, null)
		{
		}

		public override void Destroy()
		{
		}

		private void DestinationChanged(BuildableItem item)
		{
		}

		public bool DestinationFilter(BuildableItem obj, out string reason)
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
