namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ItemSet
	{
		public string[] Items;

		public global::ScheduleOne.ItemFramework.SlotFilter[] SlotFilters;

		public ItemSet(global::System.Collections.Generic.List<global::ScheduleOne.Persistence.Datas.ItemData> items)
		{
		}

		public string GetJSON()
		{
			return null;
		}

		public ItemSet(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> itemSlots)
		{
		}

		public ItemSet(global::ScheduleOne.ItemFramework.ItemSlot[] itemSlots)
		{
		}

		public void LoadTo(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> slots)
		{
		}

		public void LoadTo(global::ScheduleOne.ItemFramework.ItemSlot[] slots)
		{
		}

		public void LoadTo(global::ScheduleOne.ItemFramework.ItemSlot slot, int index = 0)
		{
		}

		public static bool TryDeserialize(string json, out global::ScheduleOne.Persistence.Datas.DeserializedItemSet itemSet)
		{
			itemSet = null;
			return false;
		}

		public static bool TryDeserialize(global::ScheduleOne.Persistence.Datas.ItemSet set, out global::ScheduleOne.Persistence.Datas.DeserializedItemSet itemSet)
		{
			itemSet = null;
			return false;
		}
	}
}
