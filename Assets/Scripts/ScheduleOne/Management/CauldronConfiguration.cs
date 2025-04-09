using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	public class CauldronConfiguration : EntityConfiguration
	{
		public NPCField AssignedChemist;

		public ObjectField Destination;

		public Cauldron Station { get; protected set; }

		public TransitRoute DestinationRoute { get; protected set; }

		public CauldronConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Cauldron cauldron)
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
