using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	[Serializable]
	public class ColorKeyframe : BaseKeyframe
	{
		public Color color;

		public ColorKeyframe(Color c, float time)
			: base(0f)
		{
		}

		public ColorKeyframe(ColorKeyframe keyframe)
			: base(0f)
		{
		}
	}
}
