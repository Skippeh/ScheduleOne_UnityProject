namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class IntegerItemData : global::ScheduleOne.Persistence.Datas.ItemData
	{
		public int Value;

		public IntegerItemData(string iD, int quantity, int value)
			: base(null, 0)
		{
		}
	}
}
