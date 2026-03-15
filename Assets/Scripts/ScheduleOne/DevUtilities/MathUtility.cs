namespace ScheduleOne.DevUtilities
{
	public static class MathUtility
	{
		public static bool PointInsideCube(global::UnityEngine.Vector3 point, global::UnityEngine.Vector3 center, global::UnityEngine.Vector3 halfExtents)
		{
			return false;
		}

		public static bool PointInsideRectangle(global::UnityEngine.Vector2 point, global::UnityEngine.Vector2 center, global::UnityEngine.Vector2 halfExtents)
		{
			return false;
		}

		public static global::UnityEngine.Vector2 ClosestPointOnSegment(global::UnityEngine.Vector2 point, global::UnityEngine.Vector2 a, global::UnityEngine.Vector2 b)
		{
			return default(global::UnityEngine.Vector2);
		}

		public static global::UnityEngine.Vector3 ClosestPointOnSegment(global::UnityEngine.Vector3 point, global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static float GetNormalizedPositionAlongSegment(global::UnityEngine.Vector2 a, global::UnityEngine.Vector2 b, global::UnityEngine.Vector2 c)
		{
			return 0f;
		}

		public static float GetNormalizedPositionAlongSegment(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, global::UnityEngine.Vector3 c)
		{
			return 0f;
		}

		public static int GetWrappedIndex(int index, int change, int size)
		{
			return 0;
		}

		public static bool BetweenValues(float value, float min, float max, bool maxInclusive = false, bool minInclusive = false)
		{
			return false;
		}

		public static float Normalise(float value, float min, float max)
		{
			return 0f;
		}

		public static float SqrDistance(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b)
		{
			return 0f;
		}

		public static float InverseDistance01(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, float minDist, float maxDist)
		{
			return 0f;
		}

		public static float InverseDistance01(float sqrDist, float minDist, float maxDist)
		{
			return 0f;
		}

		public static bool NearlyEqual(float a, float b, float tolerance)
		{
			return false;
		}

		public static float LogLerp(float a, float b, float t)
		{
			return 0f;
		}

		public static global::UnityEngine.Plane CreatePlaneFromPoints(global::UnityEngine.Vector3 p1, global::UnityEngine.Vector3 p2, global::UnityEngine.Vector3 p3)
		{
			return default(global::UnityEngine.Plane);
		}

		public static global::UnityEngine.Vector3 ClosestPointOnPlane(in global::UnityEngine.Plane plane, in global::UnityEngine.Vector3 point)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 ClosestPointOnPlane(in global::UnityEngine.Vector3 normal, float distance, in global::UnityEngine.Vector3 point)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 ClosestPointOnQuad(global::UnityEngine.Vector3 point, global::UnityEngine.Vector3 origin, global::UnityEngine.Vector3 axisU, global::UnityEngine.Vector3 axisV, float halfU, float halfV)
		{
			return default(global::UnityEngine.Vector3);
		}
	}
}
