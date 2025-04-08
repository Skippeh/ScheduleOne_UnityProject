namespace ScheduleOne.Property.Utilities.Water
{
	public class WaterManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Property.Utilities.Water.WaterManager>
	{
		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject waterPipePrefab;

		public static float pricePerL;

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

		public void ConsumeWater(float litres)
		{
		}
	}
}
