namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ShopData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string ShopCode;

		public global::ScheduleOne.DevUtilities.StringIntPair[] ItemStockQuantities;

		public ShopData(string shopCode, global::ScheduleOne.DevUtilities.StringIntPair[] itemStockQuantities)
		{
		}
	}
}
