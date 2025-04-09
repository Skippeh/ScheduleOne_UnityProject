using System.Collections.Generic;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	public class PackagerConfiguration : EntityConfiguration
	{
		public ObjectField Bed;

		public ObjectListField Stations;

		public RouteListField Routes;

		public List<PackagingStation> AssignedStations;

		public List<BrickPress> AssignedBrickPresses;

		public int AssignedStationCount => 0;

		public Packager packager { get; protected set; }

		public BedItem bedItem { get; private set; }

		public PackagerConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Packager _botanist)
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

		public void AssignedStationsChanged(List<BuildableItem> objects)
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
