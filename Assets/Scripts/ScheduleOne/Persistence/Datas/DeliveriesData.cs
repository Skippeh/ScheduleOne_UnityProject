namespace ScheduleOne.Persistence.Datas
{
	public class DeliveriesData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Delivery.DeliveryInstance[] ActiveDeliveries;

		public global::ScheduleOne.Persistence.Datas.VehicleData[] DeliveryVehicles;

		public DeliveriesData(global::ScheduleOne.Delivery.DeliveryInstance[] deliveries, global::ScheduleOne.Persistence.Datas.VehicleData[] deliveryVehicles)
		{
		}
	}
}
