using System;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	[Serializable]
	public class CashInstance : StorableItemInstance
	{
		public const float MAX_BALANCE = 1E+09f;

		public float Balance { get; protected set; }

		public CashInstance()
		{
		}

		public CashInstance(ItemDefinition definition, int quantity)
		{
		}

		public override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public void ChangeBalance(float amount)
		{
		}

		public void SetBalance(float newBalance, bool blockClear = false)
		{
		}

		public override ItemData GetItemData()
		{
			return null;
		}

		public override float GetMonetaryValue()
		{
			return 0f;
		}
	}
}
