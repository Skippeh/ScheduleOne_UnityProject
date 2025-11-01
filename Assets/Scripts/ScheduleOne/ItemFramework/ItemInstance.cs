namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	public abstract class ItemInstance
	{
		public const int APPROXIMATE_BYTE_SIZE = 50;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		protected global::ScheduleOne.ItemFramework.ItemDefinition definition;

		public string ID;

		public int Quantity;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::System.Action onDataChanged;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::System.Action requestClearSlot;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::ScheduleOne.ItemFramework.ItemDefinition Definition => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public virtual string Name => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public virtual string Description => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public virtual global::UnityEngine.Sprite Icon => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public virtual global::ScheduleOne.ItemFramework.EItemCategory Category => default(global::ScheduleOne.ItemFramework.EItemCategory);

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public virtual int StackLimit => 0;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public virtual global::UnityEngine.Color LabelDisplayColor => default(global::UnityEngine.Color);

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public virtual global::ScheduleOne.Equipping.Equippable Equippable => null;

		public ItemInstance()
		{
		}

		public ItemInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity)
		{
		}

		public virtual bool CanStackWith(global::ScheduleOne.ItemFramework.ItemInstance other, bool checkQuantities = true)
		{
			return false;
		}

		public virtual global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public virtual bool IsValidInstance()
		{
			return false;
		}

		protected void InvokeDataChange()
		{
		}

		public void SetQuantity(int quantity)
		{
		}

		public void ChangeQuantity(int change)
		{
		}

		public virtual global::ScheduleOne.Persistence.Datas.ItemData GetItemData()
		{
			return null;
		}

		public virtual float GetMonetaryValue()
		{
			return 0f;
		}

		public void RequestClearSlot()
		{
		}
	}
}
