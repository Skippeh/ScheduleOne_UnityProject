namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class WateringCanData : global::ScheduleOne.Persistence.Datas.ItemData
	{
		public float CurrentFillAmount;

		public WateringCanData(string iD, int quantity, float currentFillLevel)
			: base(null, 0)
		{
		}
	}
}
