using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.Clothing
{
	[Serializable]
	public class ClothingInstance : StorableItemInstance
	{
		public EClothingColor Color;

		public override string Name => null;

		public ClothingInstance()
		{
		}

		public ClothingInstance(ItemDefinition definition, int quantity, EClothingColor color)
		{
		}

		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public override ItemData GetItemData()
		{
			return null;
		}
	}
}
