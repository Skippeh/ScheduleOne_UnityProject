using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	public class PathPoint : MonoBehaviour
	{
		public List<PathPoint> connections;

		public bool unique;
	}
}
