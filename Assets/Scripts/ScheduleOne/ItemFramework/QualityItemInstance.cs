namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	public class QualityItemInstance : global::ScheduleOne.Storage.StorableItemInstance
	{
		public global::ScheduleOne.ItemFramework.EQuality Quality;

		public QualityItemInstance()
		{
		}

		public QualityItemInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, global::ScheduleOne.ItemFramework.EQuality quality)
		{
		}

		public override bool CanStackWith(global::ScheduleOne.ItemFramework.ItemInstance other, bool checkQuantities = true)
		{
			return false;
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.ItemData GetItemData()
		{
			return null;
		}

		public void SetQuality(global::ScheduleOne.ItemFramework.EQuality quality)
		{
		}
	}
}
