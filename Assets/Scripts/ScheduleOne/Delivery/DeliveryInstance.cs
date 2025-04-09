using System;
using FishNet.Serializing.Helping;
using ScheduleOne.DevUtilities;
using UnityEngine.Events;

namespace ScheduleOne.Delivery
{
	[Serializable]
	public class DeliveryInstance
	{
		public string DeliveryID;

		public string StoreName;

		public string DestinationCode;

		public int LoadingDockIndex;

		public StringIntPair[] Items;

		public EDeliveryStatus Status;

		public int TimeUntilArrival;

		[NonSerialized]
		[CodegenExclude]
		public UnityEvent onDeliveryCompleted;

		[CodegenExclude]
		public DeliveryVehicle ActiveVehicle { get; private set; }

		[CodegenExclude]
		public ScheduleOne.Property.Property Destination => null;

		[CodegenExclude]
		public LoadingDock LoadingDock => null;

		public DeliveryInstance(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, StringIntPair[] items, EDeliveryStatus status, int timeUntilArrival)
		{
		}

		public DeliveryInstance()
		{
		}

		public int GetTimeStatus()
		{
			return 0;
		}

		public void SetStatus(EDeliveryStatus status)
		{
		}

		public void AddItemsToDeliveryVehicle()
		{
		}

		public void OnMinPass()
		{
		}
	}
}
