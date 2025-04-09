using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class VariableData : SaveData
	{
		public string Name;

		public string Value;

		public VariableData(string name, string value)
		{
		}

		public VariableData()
		{
		}
	}
}
