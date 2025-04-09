using System;

namespace Funly.SkyStudio
{
	[Serializable]
	public class NumberKeyframe : BaseKeyframe
	{
		public float value;

		public NumberKeyframe(float time, float value)
			: base(0f)
		{
		}

		public NumberKeyframe(NumberKeyframe keyframe)
			: base(0f)
		{
		}
	}
}
