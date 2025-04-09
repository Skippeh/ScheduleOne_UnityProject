using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	public abstract class SphereUtility
	{
		private const float k_HalfPI = MathF.PI / 2f;

		public static Vector2 DirectionToSphericalCoordinate(Vector3 direction)
		{
			return default(Vector2);
		}

		public static Vector3 SphericalCoordinateToDirection(Vector2 coord)
		{
			return default(Vector3);
		}

		public static float RadiusAtHeight(float yPos)
		{
			return 0f;
		}

		public static Vector3 SphericalToPoint(float yPosition, float radAngle)
		{
			return default(Vector3);
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

		public static float AngleToReachTarget(Vector2 point, float targetAngle)
		{
			return 0f;
		}

		public static float Atan2Positive(float y, float x)
		{
			return 0f;
		}

		public static Vector3 RotateAroundXAxis(Vector3 point, float angle)
		{
			return default(Vector3);
		}

		public static Vector3 RotateAroundYAxis(Vector3 point, float angle)
		{
			return default(Vector3);
		}

		public static Vector3 RotatePoint(Vector3 point, float xAxisRotation, float yAxisRotation)
		{
			return default(Vector3);
		}

		public static Vector2 Rotate2d(Vector2 pos, float angle)
		{
			return default(Vector2);
		}

		public static Vector2 Matrix2x2Mult(Vector4 matrix, Vector2 pos)
		{
			return default(Vector2);
		}

		public static void CalculateStarRotation(Vector3 star, out float xRotationAngle, out float yRotationAngle)
		{
			xRotationAngle = default(float);
			yRotationAngle = default(float);
		}

		public static Vector2 ConvertUVToSphericalCoordinate(Vector2 uv)
		{
			return default(Vector2);
		}

		public static Vector2 ConvertSphericalCoordateToUV(Vector2 sphereCoord)
		{
			return default(Vector2);
		}
	}
}
