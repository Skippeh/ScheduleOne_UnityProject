namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class NumberKeyframe : global::Funly.SkyStudio.BaseKeyframe
	{
		public float value;

		public NumberKeyframe(float time, float value)
			: base(0f)
		{
		}

		public NumberKeyframe(global::Funly.SkyStudio.NumberKeyframe keyframe)
			: base(0f)
		{
		}
	}
}
