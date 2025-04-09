namespace Funly.SkyStudio
{
	public interface IBaseKeyframe
	{
		string id { get; }

		float time { get; set; }

		InterpolationCurve interpolationCurve { get; set; }

		InterpolationDirection interpolationDirection { get; set; }
	}
}
