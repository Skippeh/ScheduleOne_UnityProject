namespace ScheduleOne.Persistence.ItemLoaders
{
	public class ItemLoader
	{
		public virtual string ItemType => null;

		public virtual global::ScheduleOne.ItemFramework.ItemInstance LoadItem(string itemString)
		{
			return null;
		}

		protected T LoadData<T>(string itemString) where T : global::ScheduleOne.Persistence.Datas.ItemData
		{
			return null;
		}
	}
}
