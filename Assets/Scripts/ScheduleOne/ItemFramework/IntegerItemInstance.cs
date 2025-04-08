namespace ScheduleOne.ItemFramework
{
	public class IntegerItemInstance : global::ScheduleOne.Storage.StorableItemInstance
	{
		public int Value;

		public IntegerItemInstance()
		{
		}

		public IntegerItemInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, int value)
		{
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public void ChangeValue(int change)
		{
		}

		public void SetValue(int value)
		{
		}

		public override global::ScheduleOne.Persistence.Datas.ItemData GetItemData()
		{
			return null;
		}
	}
}
