using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	[Serializable]
	public class TextureKeyframeGroup : KeyframeGroup<TextureKeyframe>
	{
		public TextureKeyframeGroup(string name, TextureKeyframe keyframe)
			: base((string)null)
		{
		}

		public Texture TextureForTime(float time)
		{
			return null;
		}
	}
}
