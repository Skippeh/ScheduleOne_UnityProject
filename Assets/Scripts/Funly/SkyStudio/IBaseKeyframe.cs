namespace Funly.SkyStudio
{
	public interface IBaseKeyframe
	{
		string id { get; }

		float time { get; set; }

		global::Funly.SkyStudio.InterpolationCurve interpolationCurve { get; set; }

		global::Funly.SkyStudio.InterpolationDirection interpolationDirection { get; set; }
	}
}
