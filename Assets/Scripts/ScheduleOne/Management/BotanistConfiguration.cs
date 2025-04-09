using System.Collections.Generic;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	public class BotanistConfiguration : EntityConfiguration
	{
		public ObjectField Bed;

		public ObjectField Supplies;

		public ObjectListField AssignedStations;

		public List<Pot> AssignedPots;

		public List<DryingRack> AssignedRacks;

		public Botanist botanist { get; protected set; }

		public BedItem bedItem { get; private set; }

		public BotanistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Botanist _botanist)
			: base(null, null)
		{
		}

		public override void Destroy()
		{
		}

		private bool IsStationValid(BuildableItem obj, out string reason)
		{
			reason = null;
			return false;
		}

		public void AssignedPotsChanged(List<BuildableItem> objects)
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

		private void BedChanged(BuildableItem newItem)
		{
		}
	}
}
