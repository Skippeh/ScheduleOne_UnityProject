using System;
using FishNet.Serializing.Helping;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Storage
{
	[Serializable]
	public class StorableItemInstance : ItemInstance
	{
		[CodegenExclude]
		public virtual StoredItem StoredItem => null;

		public StorableItemInstance()
		{
		}

		public StorableItemInstance(ItemDefinition definition, int quantity)
		{
		}

		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public override float GetMonetaryValue()
		{
			return 0f;
		}
	}
}
