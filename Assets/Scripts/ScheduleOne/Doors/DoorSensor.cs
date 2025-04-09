using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Doors
{
	[RequireComponent(typeof(Rigidbody))]
	public class DoorSensor : MonoBehaviour
	{
		public const float ActivationDistance = 30f;

		public EDoorSide DetectorSide;

		public DoorController Door;

		private List<Collider> exclude;

		private Collider collider;

		private void Awake()
		{
		}

		private void UpdateCollider()
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}
	}
}
