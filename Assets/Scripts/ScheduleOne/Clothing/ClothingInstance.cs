namespace ScheduleOne.Clothing
{
	[global::System.Serializable]
	public class ClothingInstance : global::ScheduleOne.Storage.StorableItemInstance
	{
		public global::ScheduleOne.Clothing.EClothingColor Color;

		public override string Name => null;

		public ClothingInstance()
		{
		}

		public ClothingInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, global::ScheduleOne.Clothing.EClothingColor color)
		{
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.ItemData GetItemData()
		{
			return null;
		}
	}
}
