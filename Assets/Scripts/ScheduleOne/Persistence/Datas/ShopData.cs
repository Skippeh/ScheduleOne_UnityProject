namespace ScheduleOne.Persistence.Datas
{
	public class ShopData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string ShopCode;

		public global::ScheduleOne.DevUtilities.StringIntPair[] ItemStockQuantities;

		public ShopData(string shopCode, global::ScheduleOne.DevUtilities.StringIntPair[] itemStockQuantities)
		{
		}
	}
}
