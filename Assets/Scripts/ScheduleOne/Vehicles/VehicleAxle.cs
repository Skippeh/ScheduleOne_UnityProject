using UnityEngine;

namespace ScheduleOne.Vehicles
{
	public class VehicleAxle : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		protected Wheel wheel;

		private Transform model;

		protected virtual void Awake()
		{
		}

		protected virtual void LateUpdate()
		{
		}
	}
}
