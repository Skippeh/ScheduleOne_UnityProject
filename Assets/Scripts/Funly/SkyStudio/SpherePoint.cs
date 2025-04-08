namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class SpherePoint
	{
		public float horizontalRotation;

		public float verticalRotation;

		public const float MinHorizontalRotation = -global::System.MathF.PI;

		public const float MaxHorizontalRotation = global::System.MathF.PI;

		public const float MinVerticalRotation = -global::System.MathF.PI / 2f;

		public const float MaxVerticalRotation = global::System.MathF.PI / 2f;

		public SpherePoint(float horizontalRotation, float verticalRotation)
		{
		}

		public SpherePoint(global::UnityEngine.Vector3 worldDirection)
		{
		}

		public void SetFromWorldDirection(global::UnityEngine.Vector3 worldDirection)
		{
		}

		public global::UnityEngine.Vector3 GetWorldDirection()
		{
			return default(global::UnityEngine.Vector3);
		}
	}
}
