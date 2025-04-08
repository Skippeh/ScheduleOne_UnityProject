namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class QualityItemData : global::ScheduleOne.Persistence.Datas.ItemData
	{
		public string Quality;

		public QualityItemData(string iD, int quantity, string quality)
			: base(null, 0)
		{
		}
	}
}
