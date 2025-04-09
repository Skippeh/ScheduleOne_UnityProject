using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	public class VehicleRecoveryPoint : MonoBehaviour
	{
		public static List<VehicleRecoveryPoint> recoveryPoints;

		protected virtual void Awake()
		{
		}

		public static VehicleRecoveryPoint GetClosestRecoveryPoint(Vector3 pos)
		{
			return null;
		}
	}
}
