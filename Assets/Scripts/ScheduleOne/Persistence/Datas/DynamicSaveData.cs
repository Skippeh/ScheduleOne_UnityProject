namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class DynamicSaveData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		[global::System.Serializable]
		public class AdditionalData
		{
			public string Name;

			public string Contents;
		}

		public string BaseData;

		public global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Datas.DynamicSaveData.AdditionalData> AdditionalDatas;

		public DynamicSaveData(global::ScheduleOne.Persistence.Datas.SaveData baseData)
		{
		}

		public void AddData(string name, string contents)
		{
		}

		public void AddData(string name, global::ScheduleOne.Persistence.Datas.SaveData data)
		{
		}

		public string GetData(string name)
		{
			return null;
		}

		public bool TryGetData(string name, out string data)
		{
			data = null;
			return false;
		}

		public T GetData<T>(string name) where T : global::ScheduleOne.Persistence.Datas.SaveData
		{
			return null;
		}

		public bool TryGetData<T>(string name, out T data) where T : global::ScheduleOne.Persistence.Datas.SaveData
		{
			data = null;
			return false;
		}

		public T ExtractBaseData<T>() where T : global::ScheduleOne.Persistence.Datas.SaveData
		{
			return null;
		}

		public bool TryExtractBaseData<T>(out T data) where T : global::ScheduleOne.Persistence.Datas.SaveData
		{
			data = null;
			return false;
		}
	}
}
