namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class WorldStorageEntityData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string GUID;

		public global::ScheduleOne.Persistence.Datas.ItemSet Contents;

		public global::ScheduleOne.GameTime.GameDateTime LastContentChangeTime;

		public WorldStorageEntityData(global::System.Guid guid, global::ScheduleOne.Persistence.Datas.ItemSet contents, global::ScheduleOne.GameTime.GameDateTime lastContentChangeTime)
		{
		}
	}
}
