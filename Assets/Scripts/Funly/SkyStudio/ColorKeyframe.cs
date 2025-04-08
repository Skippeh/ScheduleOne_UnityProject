namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class ColorKeyframe : global::Funly.SkyStudio.BaseKeyframe
	{
		public global::UnityEngine.Color color;

		public ColorKeyframe(global::UnityEngine.Color c, float time)
			: base(0f)
		{
		}

		public ColorKeyframe(global::Funly.SkyStudio.ColorKeyframe keyframe)
			: base(0f)
		{
		}
	}
}
