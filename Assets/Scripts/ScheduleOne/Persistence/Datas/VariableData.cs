namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class VariableData : global::ScheduleOne.Persistence.Datas.SaveData
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
