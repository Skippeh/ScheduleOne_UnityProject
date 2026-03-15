namespace ScheduleOne.Clothing
{
	[global::System.Serializable]
	public class ClothingInstance : global::ScheduleOne.Storage.StorableItemInstance
	{
		public global::ScheduleOne.Clothing.EClothingColor Color;

		public override string Name => null;

		public ClothingInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, global::ScheduleOne.Clothing.EClothingColor color)
			: base(null, 0)
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

		public override void Write(global::FishNet.Serializing.Writer writer)
		{
		}

		public override void Read(global::FishNet.Serializing.Reader reader)
		{
		}
	}
}
