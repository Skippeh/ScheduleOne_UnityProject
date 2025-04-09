using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	[RequireComponent(typeof(BoxCollider))]
	public class SpeedZone : MonoBehaviour
	{
		public static List<SpeedZone> speedZones;

		public BoxCollider col;

		public float speed;

		public virtual void Awake()
		{
		}

		public static List<SpeedZone> GetSpeedZones(Vector3 point)
		{
			return null;
		}

		private void OnDrawGizmos()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
