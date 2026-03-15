namespace ScheduleOne.Delivery
{
	[global::System.Serializable]
	public class DeliveryReceipt
	{
		public string StoreName;

		public string DestinationCode;

		public int LoadingDockIndex;

		public global::ScheduleOne.DevUtilities.StringIntPair[] Items;

		public DeliveryReceipt(string storeName, string destinationCode, int loadingDockIndex, global::ScheduleOne.DevUtilities.StringIntPair[] items)
		{
		}

		public DeliveryReceipt()
		{
		}
	}
}
