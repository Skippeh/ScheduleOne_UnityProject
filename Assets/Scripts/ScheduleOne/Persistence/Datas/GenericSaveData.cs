using System;
using System.Collections.Generic;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class GenericSaveData : SaveData
	{
		[Serializable]
		public class BoolValue
		{
			public string key;

			public bool value;
		}

		[Serializable]
		public class FloatValue
		{
			public string key;

			public float value;
		}

		[Serializable]
		public class IntValue
		{
			public string key;

			public int value;
		}

		[Serializable]
		public class StringValue
		{
			public string key;

			public string value;
		}

		public string GUID;

		public List<BoolValue> boolValues;

		public List<FloatValue> floatValues;

		public List<IntValue> intValues;

		public List<StringValue> stringValues;

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
