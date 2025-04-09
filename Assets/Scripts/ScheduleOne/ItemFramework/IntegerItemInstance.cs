using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	public class IntegerItemInstance : StorableItemInstance
	{
		public int Value;

		public IntegerItemInstance()
		{
		}

		public IntegerItemInstance(ItemDefinition definition, int quantity, int value)
		{
		}

		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public void ChangeValue(int change)
		{
		}

		public void SetValue(int value)
		{
		}

		public override ItemData GetItemData()
		{
			return null;
		}
	}
}
