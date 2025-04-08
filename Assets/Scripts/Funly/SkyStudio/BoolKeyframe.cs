namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class BoolKeyframe : global::Funly.SkyStudio.BaseKeyframe
	{
		public bool value;

		public BoolKeyframe(float time, bool value)
			: base(0f)
		{
		}

		public BoolKeyframe(global::Funly.SkyStudio.BoolKeyframe keyframe)
			: base(0f)
		{
		}
	}
}
