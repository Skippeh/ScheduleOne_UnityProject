using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class SaveData
	{
		public string DataType;

		public int DataVersion;

		public string GameVersion;

		protected virtual int GetDataVersion()
		{
			return 0;
		}

		public virtual string GetJson(bool prettyPrint = true)
		{
			return null;
		}
	}
}
