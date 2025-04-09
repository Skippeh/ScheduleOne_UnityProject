using System;

namespace Funly.SkyStudio
{
	[Serializable]
	public class SpherePointKeyframeGroup : KeyframeGroup<SpherePointKeyframe>
	{
		public const float MinHorizontalRotation = -MathF.PI;

		public const float MaxHorizontalRotation = MathF.PI;

		public const float MinVerticalRotation = -MathF.PI / 2f;

		public const float MaxVerticalRotation = MathF.PI / 2f;

		public SpherePointKeyframeGroup(string name)
			: base((string)null)
		{
		}

		public SpherePointKeyframeGroup(string name, SpherePointKeyframe keyframe)
			: base((string)null)
		{
		}

		public SpherePoint SpherePointForTime(float time)
		{
			return null;
		}
	}
}
