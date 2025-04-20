namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class WorldStorageEntitiesData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.WorldStorageEntityData[] Entities;

		public WorldStorageEntitiesData(global::ScheduleOne.Persistence.Datas.WorldStorageEntityData[] entities)
		{
		}
	}
}
