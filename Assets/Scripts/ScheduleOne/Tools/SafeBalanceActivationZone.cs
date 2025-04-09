using System.Collections.Generic;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Tools
{
	public class SafeBalanceActivationZone : MonoBehaviour
	{
		public const float ActivationDistance = 30f;

		public Safe Safe;

		private List<Collider> exclude;

		private Collider[] colliders;

		private bool active;

		private void Awake()
		{
		}

		private void UpdateCollider()
		{
		}

		private void Activate()
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}
	}
}
