namespace ScheduleOne.Persistence
{
	public interface IGenericSaveable
	{
		global::System.Guid GUID { get; }

		void InitializeSaveable()
		{
		}

		void Load(global::ScheduleOne.Persistence.Datas.GenericSaveData data);

		global::ScheduleOne.Persistence.Datas.GenericSaveData GetSaveData();
	}
}
