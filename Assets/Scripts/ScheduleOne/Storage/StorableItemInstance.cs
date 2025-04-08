namespace ScheduleOne.Storage
{
	[global::System.Serializable]
	public class StorableItemInstance : global::ScheduleOne.ItemFramework.ItemInstance
	{
		[global::FishNet.Serializing.Helping.CodegenExclude]
		public virtual global::ScheduleOne.Storage.StoredItem StoredItem => null;

		public StorableItemInstance()
		{
		}

		public StorableItemInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity)
		{
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public override float GetMonetaryValue()
		{
			return 0f;
		}
	}
}
