namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class BotanistConfigurationData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Bed;

		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Supplies;

		public global::ScheduleOne.Persistence.Datas.ObjectListFieldData Pots;

		public BotanistConfigurationData(global::ScheduleOne.Persistence.Datas.ObjectFieldData bed, global::ScheduleOne.Persistence.Datas.ObjectFieldData supplies, global::ScheduleOne.Persistence.Datas.ObjectListFieldData pots)
		{
		}
	}
}
