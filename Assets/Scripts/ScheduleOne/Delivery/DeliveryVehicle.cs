using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Delivery
{
	[RequireComponent(typeof(LandVehicle))]
	public class DeliveryVehicle : MonoBehaviour
	{
		public string GUID;

		public LandVehicle Vehicle { get; private set; }

		public DeliveryInstance ActiveDelivery { get; private set; }

		private void Awake()
		{
		}

		public void Activate(DeliveryInstance instance)
		{
		}

		public void Deactivate()
		{
		}
	}
}
