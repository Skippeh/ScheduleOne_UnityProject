namespace ScheduleOne.Property.Utilities.Power
{
	public class PowerManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Property.Utilities.Power.PowerManager>
	{
		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject powerLineSegmentPrefab;

		public static float pricePerkWh;

		private global::System.Collections.Generic.Dictionary<int, float> usageAtTime;

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

		public global::ScheduleOne.Property.Utilities.Power.PowerLine CreatePowerLine(global::ScheduleOne.Property.Utilities.Power.PowerNode nodeA, global::ScheduleOne.Property.Utilities.Power.PowerNode nodeB, global::ScheduleOne.Property.Property p)
		{
			return null;
		}
	}
}
