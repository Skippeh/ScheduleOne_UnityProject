namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class VariableCollectionData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.VariableData[] Variables;

		public VariableCollectionData(global::ScheduleOne.Persistence.Datas.VariableData[] variables)
		{
		}
	}
}
