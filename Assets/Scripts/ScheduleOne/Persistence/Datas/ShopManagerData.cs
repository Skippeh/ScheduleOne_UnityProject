namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ShopManagerData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.ShopData[] Shops;

		public ShopManagerData(global::ScheduleOne.Persistence.Datas.ShopData[] shops)
		{
		}
	}
}
