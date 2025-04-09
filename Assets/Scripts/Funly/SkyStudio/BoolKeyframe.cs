using System;

namespace Funly.SkyStudio
{
	[Serializable]
	public class BoolKeyframe : BaseKeyframe
	{
		public bool value;

		public BoolKeyframe(float time, bool value)
			: base(0f)
		{
		}

		public BoolKeyframe(BoolKeyframe keyframe)
			: base(0f)
		{
		}
	}
}
