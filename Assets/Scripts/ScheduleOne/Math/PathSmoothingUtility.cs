namespace ScheduleOne.Math
{
	public static class PathSmoothingUtility
	{
		public class SmoothedPath
		{
			public const float MARGIN = 10f;

			public global::System.Collections.Generic.List<global::UnityEngine.Vector3> vectorPath;

			public global::System.Collections.Generic.List<global::UnityEngine.Bounds> segmentBounds;

			public void InitializePath()
			{
			}
		}

		private const float MinControlPointDistance = 0.5f;

		private static global::FluffyUnderware.Curvy.CurvySpline _spline;

		public static void EnsureSplineInitialized()
		{
		}

		public static global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath CalculateSmoothedPath(global::System.Collections.Generic.List<global::UnityEngine.Vector3> controlPoints, float maxCPDistance = 5f)
		{
			return null;
		}

		private static void DrawPath(global::ScheduleOne.Math.PathSmoothingUtility.SmoothedPath path, global::UnityEngine.Color col, float duration)
		{
		}

		private static global::System.Collections.Generic.List<global::UnityEngine.Vector3> InsertIntermediatePoints(global::System.Collections.Generic.List<global::UnityEngine.Vector3> points, float maxDistance)
		{
			return null;
		}
	}
}
