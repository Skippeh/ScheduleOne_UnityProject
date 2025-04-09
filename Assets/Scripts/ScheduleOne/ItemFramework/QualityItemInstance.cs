using System;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	[Serializable]
	public class QualityItemInstance : StorableItemInstance
	{
		public EQuality Quality;

		public QualityItemInstance()
		{
		}

		public QualityItemInstance(ItemDefinition definition, int quantity, EQuality quality)
		{
		}

		public override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			return false;
		}

		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public override ItemData GetItemData()
		{
			return null;
		}

		public void SetQuality(EQuality quality)
		{
		}
	}
}
