using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Vehicles
{
	public class VehicleCollisionDetector : MonoBehaviour
	{
		public UnityEvent<Collision> onCollisionEnter;

		public void OnCollisionEnter(Collision collision)
		{
		}
	}
}
