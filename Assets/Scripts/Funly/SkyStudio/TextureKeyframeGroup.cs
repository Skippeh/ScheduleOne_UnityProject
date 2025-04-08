namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class TextureKeyframeGroup : global::Funly.SkyStudio.KeyframeGroup<global::Funly.SkyStudio.TextureKeyframe>
	{
		public TextureKeyframeGroup(string name, global::Funly.SkyStudio.TextureKeyframe keyframe)
			: base((string)null)
		{
		}

		public global::UnityEngine.Texture TextureForTime(float time)
		{
			return null;
		}
	}
}
