namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class PotConfigurationData : global::ScheduleOne.Persistence.Datas.RenamableConfigurationData
	{
		public global::ScheduleOne.Persistence.Datas.ItemFieldData Seed;

		public global::ScheduleOne.Persistence.Datas.ItemFieldData Additive1;

		public global::ScheduleOne.Persistence.Datas.ItemFieldData Additive2;

		public global::ScheduleOne.Persistence.Datas.ItemFieldData Additive3;

		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Destination;

		public PotConfigurationData(global::ScheduleOne.Persistence.Datas.StringFieldData name, global::ScheduleOne.Persistence.Datas.ItemFieldData seed, global::ScheduleOne.Persistence.Datas.ItemFieldData additive1, global::ScheduleOne.Persistence.Datas.ItemFieldData additive2, global::ScheduleOne.Persistence.Datas.ItemFieldData additive3, global::ScheduleOne.Persistence.Datas.ObjectFieldData destination)
			: base(null)
		{
		}
	}
}
