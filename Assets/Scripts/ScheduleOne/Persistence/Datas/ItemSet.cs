namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ItemSet
	{
		public string[] Items;

		public ItemSet(global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Datas.ItemData> items)
		{
		}

		public string GetJSON()
		{
			return null;
		}

		public ItemSet(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items)
		{
		}

		public ItemSet(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> itemSlots)
		{
		}

		public ItemSet(global::ScheduleOne.ItemFramework.ItemSlot[] itemSlots)
		{
		}

		public static global::ScheduleOne.ItemFramework.ItemInstance[] Deserialize(string json)
		{
			return null;
		}
	}
}
