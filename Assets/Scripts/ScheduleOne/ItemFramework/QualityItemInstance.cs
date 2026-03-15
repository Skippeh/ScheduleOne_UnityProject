namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	public class QualityItemInstance : global::ScheduleOne.Storage.StorableItemInstance
	{
		public global::ScheduleOne.ItemFramework.EQuality Quality;

		public QualityItemInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, global::ScheduleOne.ItemFramework.EQuality quality)
			: base(null, 0)
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

		public override void Write(global::FishNet.Serializing.Writer writer)
		{
		}

		public override void Read(global::FishNet.Serializing.Reader reader)
		{
		}
	}
}
