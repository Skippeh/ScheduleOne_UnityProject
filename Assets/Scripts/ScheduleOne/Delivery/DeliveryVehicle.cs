namespace ScheduleOne.Delivery
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Vehicles.LandVehicle))]
	public class DeliveryVehicle : global::UnityEngine.MonoBehaviour
	{
		public string GUID;

		public global::ScheduleOne.Vehicles.LandVehicle Vehicle { get; private set; }

		public global::ScheduleOne.Delivery.DeliveryInstance ActiveDelivery { get; private set; }

		private void Awake()
		{
		}

		public void Activate(global::ScheduleOne.Delivery.DeliveryInstance instance)
		{
		}

		public void Deactivate()
		{
		}
	}
}
