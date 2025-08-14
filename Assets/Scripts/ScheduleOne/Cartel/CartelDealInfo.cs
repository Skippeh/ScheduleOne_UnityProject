namespace ScheduleOne.Cartel
{
	[global::System.Serializable]
	public class CartelDealInfo
	{
		public enum EStatus
		{
			Pending = 0,
			Overdue = 1
		}

		public string RequestedProductID;

		public int RequestedProductQuantity;

		public int PaymentAmount;

		public global::ScheduleOne.GameTime.GameDateTime DueTime;

		public global::ScheduleOne.Cartel.CartelDealInfo.EStatus Status;

		public CartelDealInfo(string requestedProductID, int requestedProductQuantity, int payment, global::ScheduleOne.GameTime.GameDateTime dueTime, global::ScheduleOne.Cartel.CartelDealInfo.EStatus status)
		{
		}

		public CartelDealInfo()
		{
		}

		public bool IsValid()
		{
			return false;
		}
	}
}
