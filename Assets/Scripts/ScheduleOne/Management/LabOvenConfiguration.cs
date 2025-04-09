using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	public class LabOvenConfiguration : EntityConfiguration
	{
		public NPCField AssignedChemist;

		public ObjectField Destination;

		public LabOven Oven { get; protected set; }

		public TransitRoute DestinationRoute { get; protected set; }

		public LabOvenConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, LabOven oven)
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
