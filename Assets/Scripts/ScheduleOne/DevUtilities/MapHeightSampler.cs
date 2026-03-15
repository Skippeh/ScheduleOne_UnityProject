namespace ScheduleOne.DevUtilities
{
	public static class MapHeightSampler
	{
		private const float SampleHeight = 100f;

		private const float SampleDistance = 200f;

		public static bool TrySample(float x, float z, out global::UnityEngine.Vector3 hitPoint)
		{
			hitPoint = default(global::UnityEngine.Vector3);
			return false;
		}
	}
}
