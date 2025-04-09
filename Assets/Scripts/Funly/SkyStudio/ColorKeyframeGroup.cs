using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	[Serializable]
	public class ColorKeyframeGroup : KeyframeGroup<ColorKeyframe>
	{
		public ColorKeyframeGroup(string name)
			: base((string)null)
		{
		}

		public ColorKeyframeGroup(string name, ColorKeyframe frame)
			: base((string)null)
		{
		}

		public Color ColorForTime(float time)
		{
			return default(Color);
		}
	}
}
