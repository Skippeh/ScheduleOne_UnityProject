using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	[Serializable]
	public class SpherePoint
	{
		public float horizontalRotation;

		public float verticalRotation;

		public const float MinHorizontalRotation = -MathF.PI;

		public const float MaxHorizontalRotation = MathF.PI;

		public const float MinVerticalRotation = -MathF.PI / 2f;

		public const float MaxVerticalRotation = MathF.PI / 2f;

		public SpherePoint(float horizontalRotation, float verticalRotation)
		{
		}

		public SpherePoint(Vector3 worldDirection)
		{
		}

		public void SetFromWorldDirection(Vector3 worldDirection)
		{
		}

		public Vector3 GetWorldDirection()
		{
			return default(Vector3);
		}
	}
}
