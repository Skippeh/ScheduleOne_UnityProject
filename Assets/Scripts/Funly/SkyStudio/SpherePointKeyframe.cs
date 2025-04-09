using System;

namespace Funly.SkyStudio
{
	[Serializable]
	public class SpherePointKeyframe : BaseKeyframe
	{
		public SpherePoint spherePoint;

		public SpherePointKeyframe(SpherePoint spherePoint, float time)
			: base(0f)
		{
		}

		public SpherePointKeyframe(SpherePointKeyframe keyframe)
			: base(0f)
		{
		}
	}
}
