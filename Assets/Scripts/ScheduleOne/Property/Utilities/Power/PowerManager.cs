using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Property.Utilities.Power
{
	public class PowerManager : Singleton<PowerManager>
	{
		[Header("Prefabs")]
		public GameObject powerLineSegmentPrefab;

		public static float pricePerkWh;

		private Dictionary<int, float> usageAtTime;

		private float usageThisMinute;

		protected override void Start()
		{
		}

		private void MinPass()
		{
		}

		private void DayPass()
		{
		}

		public float GetTotalUsage()
		{
			return 0f;
		}

		public void ConsumePower(float kwh)
		{
		}

		public PowerLine CreatePowerLine(PowerNode nodeA, PowerNode nodeB, Property p)
		{
			return null;
		}
	}
}
