namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class ColorKeyframeGroup : global::Funly.SkyStudio.KeyframeGroup<global::Funly.SkyStudio.ColorKeyframe>
	{
		public ColorKeyframeGroup(string name)
			: base((string)null)
		{
		}

		public ColorKeyframeGroup(string name, global::Funly.SkyStudio.ColorKeyframe frame)
			: base((string)null)
		{
		}

		public global::UnityEngine.Color ColorForTime(float time)
		{
			return default(global::UnityEngine.Color);
		}
	}
}
