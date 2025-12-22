namespace ScheduleOne.Temperature
{
	public struct TemperatureEmitterInfo
	{
		public float Temperature;

		public float SqrRange;

		public global::UnityEngine.Vector3 Position;

		public static int SizeOf => 0;

		public TemperatureEmitterInfo(float temperature, float sqrRange, global::UnityEngine.Vector3 position)
		{
			Temperature = 0f;
			SqrRange = 0f;
			Position = default(global::UnityEngine.Vector3);
		}
	}
}
