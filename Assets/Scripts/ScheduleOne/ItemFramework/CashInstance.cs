namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	public class CashInstance : global::ScheduleOne.Storage.StorableItemInstance
	{
		public const float MAX_BALANCE = 1E+09f;

		public float Balance { get; protected set; }

		public CashInstance()
		{
		}

		public CashInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity)
		{
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public void ChangeBalance(float amount)
		{
		}

		public void SetBalance(float newBalance, bool blockClear = false)
		{
		}

		public override global::ScheduleOne.Persistence.Datas.ItemData GetItemData()
		{
			return null;
		}

		public override float GetMonetaryValue()
		{
			return 0f;
		}
	}
}
