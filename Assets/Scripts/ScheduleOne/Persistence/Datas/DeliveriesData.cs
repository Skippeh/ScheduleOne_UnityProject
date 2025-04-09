using ScheduleOne.Delivery;

namespace ScheduleOne.Persistence.Datas
{
	public class DeliveriesData : SaveData
	{
		public DeliveryInstance[] ActiveDeliveries;

		public DeliveriesData(DeliveryInstance[] deliveries)
		{
		}
	}
}
