namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class SpherePointKeyframeGroup : global::Funly.SkyStudio.KeyframeGroup<global::Funly.SkyStudio.SpherePointKeyframe>
	{
		public const float MinHorizontalRotation = -global::System.MathF.PI;

		public const float MaxHorizontalRotation = global::System.MathF.PI;

		public const float MinVerticalRotation = -global::System.MathF.PI / 2f;

		public const float MaxVerticalRotation = global::System.MathF.PI / 2f;

		public SpherePointKeyframeGroup(string name)
			: base((string)null)
		{
		}

		public SpherePointKeyframeGroup(string name, global::Funly.SkyStudio.SpherePointKeyframe keyframe)
			: base((string)null)
		{
		}

		public global::Funly.SkyStudio.SpherePoint SpherePointForTime(float time)
		{
			return null;
		}
	}
}
