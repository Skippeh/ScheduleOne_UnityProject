using System;
using UnityEngine;

namespace Funly.SkyStudio
{
	[Serializable]
	public class TextureKeyframe : BaseKeyframe
	{
		public Texture texture;

		public TextureKeyframe(Texture texture, float time)
			: base(0f)
		{
		}

		public TextureKeyframe(TextureKeyframe keyframe)
			: base(0f)
		{
		}
	}
}
