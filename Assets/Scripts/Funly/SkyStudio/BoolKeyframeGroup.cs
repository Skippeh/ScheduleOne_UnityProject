using System;

namespace Funly.SkyStudio
{
	[Serializable]
	public class BoolKeyframeGroup : KeyframeGroup<BoolKeyframe>
	{
		public BoolKeyframeGroup(string name)
			: base((string)null)
		{
		}

		public BoolKeyframeGroup(string name, BoolKeyframe keyframe)
			: base((string)null)
		{
		}

		public bool BoolForTime(float time)
		{
			return false;
		}
	}
}
