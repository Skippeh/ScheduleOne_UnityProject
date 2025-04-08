namespace Funly.SkyStudio
{
	[global::System.Serializable]
	public class SpherePointKeyframe : global::Funly.SkyStudio.BaseKeyframe
	{
		public global::Funly.SkyStudio.SpherePoint spherePoint;

		public SpherePointKeyframe(global::Funly.SkyStudio.SpherePoint spherePoint, float time)
			: base(0f)
		{
		}

		public SpherePointKeyframe(global::Funly.SkyStudio.SpherePointKeyframe keyframe)
			: base(0f)
		{
		}
	}
}
