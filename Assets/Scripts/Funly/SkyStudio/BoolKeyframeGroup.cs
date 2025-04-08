namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class BoolKeyframeGroup : global::Funly.SkyStudio.KeyframeGroup<global::Funly.SkyStudio.BoolKeyframe>
	{
		public BoolKeyframeGroup(string name)
			: base((string)null)
		{
		}

		public BoolKeyframeGroup(string name, global::Funly.SkyStudio.BoolKeyframe keyframe)
			: base((string)null)
		{
		}

		public bool BoolForTime(float time)
		{
			return false;
		}
	}
}
