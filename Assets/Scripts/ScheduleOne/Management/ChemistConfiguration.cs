using System.Collections.Generic;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	public class ChemistConfiguration : EntityConfiguration
	{
		public ObjectField Bed;

		public ObjectListField Stations;

		public List<ChemistryStation> ChemStations;

		public List<LabOven> LabOvens;

		public List<Cauldron> Cauldrons;

		public List<MixingStation> MixStations;

		public int TotalStations => 0;

		public Chemist chemist { get; protected set; }

		public BedItem bedItem { get; private set; }

		public ChemistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Chemist _chemist)
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
