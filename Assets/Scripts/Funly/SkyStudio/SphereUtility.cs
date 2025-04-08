namespace Funly.SkyStudio
{
	public abstract class SphereUtility
	{
		private const float k_HalfPI = global::System.MathF.PI / 2f;

		public static global::UnityEngine.Vector2 DirectionToSphericalCoordinate(global::UnityEngine.Vector3 direction)
		{
			return default(global::UnityEngine.Vector2);
		}

		public static global::UnityEngine.Vector3 SphericalCoordinateToDirection(global::UnityEngine.Vector2 coord)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static float RadiusAtHeight(float yPos)
		{
			return 0f;
		}

		public static global::UnityEngine.Vector3 SphericalToPoint(float yPosition, float radAngle)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static float RadAngleToPercent(float radAngle)
		{
			return 0f;
		}

		public static float PercentToRadAngle(float percent)
		{
			return 0f;
		}

		public static float HeightToPercent(float yValue)
		{
			return 0f;
		}

		public static float PercentToHeight(float hPercent)
		{
			return 0f;
		}

		public static float AngleToReachTarget(global::UnityEngine.Vector2 point, float targetAngle)
		{
			return 0f;
		}

		public static float Atan2Positive(float y, float x)
		{
			return 0f;
		}

		public static global::UnityEngine.Vector3 RotateAroundXAxis(global::UnityEngine.Vector3 point, float angle)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 RotateAroundYAxis(global::UnityEngine.Vector3 point, float angle)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector3 RotatePoint(global::UnityEngine.Vector3 point, float xAxisRotation, float yAxisRotation)
		{
			return default(global::UnityEngine.Vector3);
		}

		public static global::UnityEngine.Vector2 Rotate2d(global::UnityEngine.Vector2 pos, float angle)
		{
			return default(global::UnityEngine.Vector2);
		}

		public static global::UnityEngine.Vector2 Matrix2x2Mult(global::UnityEngine.Vector4 matrix, global::UnityEngine.Vector2 pos)
		{
			return default(global::UnityEngine.Vector2);
		}

		public static void CalculateStarRotation(global::UnityEngine.Vector3 star, out float xRotationAngle, out float yRotationAngle)
		{
			xRotationAngle = default(float);
			yRotationAngle = default(float);
		}

		public static global::UnityEngine.Vector2 ConvertUVToSphericalCoordinate(global::UnityEngine.Vector2 uv)
		{
			return default(global::UnityEngine.Vector2);
		}

		public static global::UnityEngine.Vector2 ConvertSphericalCoordateToUV(global::UnityEngine.Vector2 sphereCoord)
		{
			return default(global::UnityEngine.Vector2);
		}
	}
}
