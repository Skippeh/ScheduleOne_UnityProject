namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ChemistryStationConfigurationData : global::ScheduleOne.Persistence.Datas.RenamableConfigurationData
	{
		public global::ScheduleOne.Persistence.Datas.StationRecipeFieldData Recipe;

		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Destination;

		public ChemistryStationConfigurationData(global::ScheduleOne.Persistence.Datas.StringFieldData name, global::ScheduleOne.Persistence.Datas.StationRecipeFieldData recipe, global::ScheduleOne.Persistence.Datas.ObjectFieldData destination)
			: base(null)
		{
		}
	}
}
