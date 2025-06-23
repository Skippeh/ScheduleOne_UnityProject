namespace ScheduleOne.Persistence.Loaders
{
	public class DynamicLoader
	{
		public void Load(string serializedDynamicSaveData)
		{
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.DynamicSaveData saveData)
		{
		}

		public static T ExtractBaseData<T>(global::ScheduleOne.Persistence.Datas.DynamicSaveData saveData) where T : global::ScheduleOne.Persistence.Datas.SaveData
		{
			return null;
		}

		public static bool TryExtractBaseData<T>(global::ScheduleOne.Persistence.Datas.DynamicSaveData saveData, out T baseData) where T : global::ScheduleOne.Persistence.Datas.SaveData
		{
			baseData = null;
			return false;
		}
	}
}
