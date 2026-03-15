namespace ScheduleOne.ItemFramework
{
	public class IntegerItemInstance : global::ScheduleOne.Storage.StorableItemInstance
	{
		public int Value;

		public IntegerItemInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, int value)
			: base(null, 0)
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

		public override void Write(global::FishNet.Serializing.Writer writer)
		{
		}

		public override void Read(global::FishNet.Serializing.Reader reader)
		{
		}
	}
}
