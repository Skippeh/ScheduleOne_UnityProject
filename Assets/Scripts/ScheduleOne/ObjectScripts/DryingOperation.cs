namespace ScheduleOne.ObjectScripts
{
	[global::System.Serializable]
	public class DryingOperation
	{
		public string ItemID;

		public int Quantity;

		public global::ScheduleOne.ItemFramework.EQuality StartQuality;

		public float Time;

		public DryingOperation(string itemID, int quantity, global::ScheduleOne.ItemFramework.EQuality startQuality, float time)
		{
		}

		public DryingOperation()
		{
		}

		public void IncreaseQuality()
		{
		}

		public global::ScheduleOne.ItemFramework.QualityItemInstance GetQualityItemInstance()
		{
			return null;
		}

		public global::ScheduleOne.ItemFramework.EQuality GetQuality()
		{
			return default(global::ScheduleOne.ItemFramework.EQuality);
		}
	}
}
