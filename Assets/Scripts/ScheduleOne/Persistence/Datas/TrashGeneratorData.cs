namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class TrashGeneratorData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string GUID;

		public string[] GeneratedItems;

		public TrashGeneratorData(string guid, string[] generatedItems)
		{
		}
	}
}
