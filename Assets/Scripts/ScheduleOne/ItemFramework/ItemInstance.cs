using System;
using FishNet.Serializing.Helping;
using ScheduleOne.Equipping;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	[Serializable]
	public abstract class ItemInstance
	{
		[CodegenExclude]
		protected ItemDefinition definition;

		public string ID;

		public int Quantity;

		[CodegenExclude]
		public Action onDataChanged;

		[CodegenExclude]
		public Action requestClearSlot;

		[CodegenExclude]
		public ItemDefinition Definition => null;

		[CodegenExclude]
		public virtual string Name => null;

		[CodegenExclude]
		public virtual string Description => null;

		[CodegenExclude]
		public virtual Sprite Icon => null;

		[CodegenExclude]
		public virtual EItemCategory Category => default(EItemCategory);

		[CodegenExclude]
		public virtual int StackLimit => 0;

		[CodegenExclude]
		public virtual Color LabelDisplayColor => default(Color);

		[CodegenExclude]
		public virtual Equippable Equippable => null;

		public ItemInstance()
		{
		}

		public ItemInstance(ItemDefinition definition, int quantity)
		{
		}

		public virtual bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			return false;
		}

		public virtual ItemInstance GetCopy(int overrideQuantity = -1)
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

		public virtual ItemData GetItemData()
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
