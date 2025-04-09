using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	[Serializable]
	public class WateringCanInstance : StorableItemInstance
	{
		public float CurrentFillAmount;

		public WateringCanInstance()
		{
		}

		public WateringCanInstance(ItemDefinition definition, int quantity, float fillAmount)
		{
		}

		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public void ChangeFillAmount(float change)
		{
		}

		public override ItemData GetItemData()
		{
			return null;
		}
	}
}
