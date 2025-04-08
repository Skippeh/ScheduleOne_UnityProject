namespace Funly.SkyStudio
{
	public interface IKeyframeGroup
	{
		string name { get; set; }

		string id { get; }

		void SortKeyframes();

		void TrimToSingleKeyframe();

		void RemoveKeyFrame(global::Funly.SkyStudio.IBaseKeyframe keyframe);

		int GetKeyFrameCount();
	}
}
