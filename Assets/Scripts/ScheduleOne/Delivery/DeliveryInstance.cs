namespace ScheduleOne.Delivery
{
	[global::System.Serializable]
	public class DeliveryInstance
	{
		public string DeliveryID;

		public string StoreName;

		public string DestinationCode;

		public int LoadingDockIndex;

		public global::ScheduleOne.DevUtilities.StringIntPair[] Items;

		public global::ScheduleOne.Delivery.EDeliveryStatus Status;

		public int TimeUntilArrival;

		[global::System.NonSerialized]
		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::UnityEngine.Events.UnityEvent onDeliveryCompleted;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::ScheduleOne.Delivery.DeliveryVehicle ActiveVehicle { get; private set; }

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::ScheduleOne.Property.Property Destination => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::ScheduleOne.Delivery.LoadingDock LoadingDock => null;

		public DeliveryInstance(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, global::ScheduleOne.DevUtilities.StringIntPair[] items, global::ScheduleOne.Delivery.EDeliveryStatus status, int timeUntilArrival)
		{
		}

		public DeliveryInstance()
		{
		}

		public int GetTimeStatus()
		{
			return 0;
		}

		public void SetStatus(global::ScheduleOne.Delivery.EDeliveryStatus status)
		{
		}

		public void AddItemsToDeliveryVehicle()
		{
		}

		public void OnTimePass(int minutes)
		{
		}
	}
}
