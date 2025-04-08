namespace ScheduleOne.ObjectScripts.WateringCan
{
	[global::System.Serializable]
	public class WateringCanInstance : global::ScheduleOne.Storage.StorableItemInstance
	{
		public float CurrentFillAmount;

		public WateringCanInstance()
		{
		}

		public WateringCanInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, float fillAmount)
		{
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public void ChangeFillAmount(float change)
		{
		}

		public override global::ScheduleOne.Persistence.Datas.ItemData GetItemData()
		{
			return null;
		}
	}
}
