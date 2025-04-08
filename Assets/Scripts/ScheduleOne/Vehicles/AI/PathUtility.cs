namespace ScheduleOne.Vehicles.AI
{
	public static class PathUtility
	{
		public static global::UnityEngine.Vector3 GetAverageAheadPoint(global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath path, global::UnityEngine.Vector3 referencePoint, int sampleCount, float stepSize)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 GetAheadPoint(global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath path, global::UnityEngine.Vector3 referencePoint, float distance)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 GetAheadPoint(global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath path, global::UnityEngine.Vector3 referencePoint, float distance, int startPointIndex, float pointLerp)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 GetPointAheadOfPathPoint(global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static float CalculateAngleChangeOverPath(global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			return 0f;
		}

		public static float CalculateCTE(global::UnityEngine.Vector3 flatCarPos, global::UnityEngine.Transform vehicleTransform, global::UnityEngine.Vector3 wp_from, global::UnityEngine.Vector3 wp_to, global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath path)
		{
			return 0f;
		}

		public static global::UnityEngine.Vector3 GetClosestPointOnPath(global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath path, global::UnityEngine.Vector3 point, out int startPointIndex, out int endPointIndex, out float pointLerp)
		{
			startPointIndex = default(int);
			endPointIndex = default(int);
			pointLerp = default(float);
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 GetAheadPointDirection(global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath path, global::UnityEngine.Vector3 referencePoint, float distanceAhead)
		{
			return default(global::UnityEngine.Vector3);
		}

		private static global::UnityEngine.Vector3 GetClosestPointOnLine(global::UnityEngine.Vector3 point, global::UnityEngine.Vector3 line_start, global::UnityEngine.Vector3 line_end, bool clamp = true)
		{
			return default(global::UnityEngine.Vector3);
		}
	}
}
