namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class TextureKeyframe : global::Funly.SkyStudio.BaseKeyframe
	{
		public global::UnityEngine.Texture texture;

		public TextureKeyframe(global::UnityEngine.Texture texture, float time)
			: base(0f)
		{
		}

		public TextureKeyframe(global::Funly.SkyStudio.TextureKeyframe keyframe)
			: base(0f)
		{
		}
	}
}
