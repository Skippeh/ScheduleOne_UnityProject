namespace ScheduleOne.Delivery
{
	[global::System.Serializable]
	public class DeliveryReceipt
	{
		public string DeliveryID;

		public string StoreName;

		public string DestinationCode;

		public int LoadingDockIndex;

		public global::ScheduleOne.DevUtilities.StringIntPair[] Items;

		public DeliveryReceipt(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, global::ScheduleOne.DevUtilities.StringIntPair[] items)
		{
		}

		public DeliveryReceipt()
		{
		}
	}
}
