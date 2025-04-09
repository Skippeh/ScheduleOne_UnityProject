using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence.ItemLoaders
{
	public class ItemLoader
	{
		public virtual string ItemType => null;

		public virtual ItemInstance LoadItem(string itemString)
		{
			return null;
		}

		protected T LoadData<T>(string itemString) where T : ItemData
		{
			return null;
		}
	}
}
