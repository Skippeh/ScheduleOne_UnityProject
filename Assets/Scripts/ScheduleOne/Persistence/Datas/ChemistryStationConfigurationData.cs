using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class ChemistryStationConfigurationData : SaveData
	{
		public StationRecipeFieldData Recipe;

		public ObjectFieldData Destination;

		public ChemistryStationConfigurationData(StationRecipeFieldData recipe, ObjectFieldData destination)
		{
		}
	}
}
