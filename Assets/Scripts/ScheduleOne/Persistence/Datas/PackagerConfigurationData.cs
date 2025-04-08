namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class PackagerConfigurationData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Bed;

		public global::ScheduleOne.Persistence.Datas.ObjectListFieldData Stations;

		public global::ScheduleOne.Persistence.Datas.RouteListData Routes;

		public PackagerConfigurationData(global::ScheduleOne.Persistence.Datas.ObjectFieldData bed, global::ScheduleOne.Persistence.Datas.ObjectListFieldData stations, global::ScheduleOne.Persistence.Datas.RouteListData routes)
		{
		}
	}
}
