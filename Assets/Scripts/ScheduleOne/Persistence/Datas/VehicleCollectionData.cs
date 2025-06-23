namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class VehicleCollectionData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.VehicleData[] Vehicles;

		public VehicleCollectionData(global::ScheduleOne.Persistence.Datas.VehicleData[] vehicles)
		{
		}
	}
}
