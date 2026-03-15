namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	public class WaterContainerInstance : global::ScheduleOne.Storage.StorableItemInstance
	{
		public float CurrentFillAmount { get; private set; }

		public float NormalizedFillAmount => 0f;

		public global::ScheduleOne.ItemFramework.WaterContainerDefinition WaterContainerDefinition => null;

		public WaterContainerInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, float fillAmount)
			: base(null, 0)
		{
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public void ChangeFillAmount(float change)
		{
		}

		public void ChangeFillAmountByPercentage(float percentage)
		{
		}

		public void SetFillAmount(float amount)
		{
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
