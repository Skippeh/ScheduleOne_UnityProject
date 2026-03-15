namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	public abstract class ItemInstance : global::ScheduleOne.Core.Items.Framework.BaseItemInstance
	{
		public global::ScheduleOne.ItemFramework.ItemDefinition Definition => null;

		public virtual global::ScheduleOne.Equipping.Equippable Equippable => null;

		public ItemInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity)
			: base(null, 0)
		{
		}

		public virtual bool CanStackWith(global::ScheduleOne.ItemFramework.ItemInstance other, bool checkQuantities = true)
		{
			return false;
		}

		public abstract global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1);

		public virtual global::ScheduleOne.Persistence.Datas.ItemData GetItemData()
		{
			return null;
		}

		public virtual void Write(global::FishNet.Serializing.Writer writer)
		{
		}

		public virtual void Read(global::FishNet.Serializing.Reader reader)
		{
		}

		public static global::ScheduleOne.ItemFramework.ItemInstance CreateInstanceAndRead(global::FishNet.Serializing.Reader reader)
		{
			return null;
		}
	}
}
