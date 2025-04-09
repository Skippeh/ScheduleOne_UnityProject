using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	[RequireComponent(typeof(BoxCollider))]
	public class FunnelZone : MonoBehaviour
	{
		public static List<FunnelZone> funnelZones;

		public BoxCollider col;

		public Transform entryPoint;

		protected virtual void Awake()
		{
		}

		public static FunnelZone GetFunnelZone(Vector3 point)
		{
			return null;
		}

		private void OnDrawGizmos()
		{
		}
	}
}
