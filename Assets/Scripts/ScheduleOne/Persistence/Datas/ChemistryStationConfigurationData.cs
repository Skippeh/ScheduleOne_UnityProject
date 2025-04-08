namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ChemistryStationConfigurationData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.StationRecipeFieldData Recipe;

		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Destination;

		public ChemistryStationConfigurationData(global::ScheduleOne.Persistence.Datas.StationRecipeFieldData recipe, global::ScheduleOne.Persistence.Datas.ObjectFieldData destination)
		{
		}
	}
}
