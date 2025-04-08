namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class GenericSaveData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		[global::System.Serializable]
		public class BoolValue
		{
			public string key;

			public bool value;
		}

		[global::System.Serializable]
		public class FloatValue
		{
			public string key;

			public float value;
		}

		[global::System.Serializable]
		public class IntValue
		{
			public string key;

			public int value;
		}

		[global::System.Serializable]
		public class StringValue
		{
			public string key;

			public string value;
		}

		public string GUID;

		public global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Datas.GenericSaveData.BoolValue> boolValues;

		public global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Datas.GenericSaveData.FloatValue> floatValues;

		public global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Datas.GenericSaveData.IntValue> intValues;

		public global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Datas.GenericSaveData.StringValue> stringValues;

		public GenericSaveData(string guid)
		{
		}

		public void Add(string key, bool value)
		{
		}

		public void Add(string key, float value)
		{
		}

		public void Add(string key, int value)
		{
		}

		public void Add(string key, string value)
		{
		}

		public bool GetBool(string key, bool defaultValue = false)
		{
			return false;
		}

		public float GetFloat(string key, float defaultValue = 0f)
		{
			return 0f;
		}

		public int GetInt(string key, int defaultValue = 0)
		{
			return 0;
		}

		public string GetString(string key, string defaultValue = "")
		{
			return null;
		}
	}
}
