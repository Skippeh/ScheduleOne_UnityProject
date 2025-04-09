using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class ItemSet
	{
		public string[] Items;

		public ItemSet(List<ItemData> items)
		{
		}

		public string GetJSON()
		{
			return null;
		}

		public ItemSet(List<ItemInstance> items)
		{
		}

		public ItemSet(List<ItemSlot> itemSlots)
		{
		}

		public ItemSet(ItemSlot[] itemSlots)
		{
		}

		public static ItemInstance[] Deserialize(string json)
		{
			return null;
		}
	}
}
