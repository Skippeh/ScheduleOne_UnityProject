using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	public class DryingRackConfiguration : EntityConfiguration
	{
		public NPCField AssignedBotanist;

		public QualityField TargetQuality;

		public ObjectField Destination;

		public DryingRack Rack { get; protected set; }

		public TransitRoute DestinationRoute { get; protected set; }

		public DryingRackConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, DryingRack rack)
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
