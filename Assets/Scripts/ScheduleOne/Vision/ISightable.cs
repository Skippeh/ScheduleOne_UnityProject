namespace ScheduleOne.Vision
{
	public interface ISightable
	{
		global::FishNet.Object.NetworkObject NetworkObject { get; }

		global::ScheduleOne.Vision.VisionEvent HighestProgressionEvent { get; set; }

		global::ScheduleOne.Vision.EntityVisibility VisibilityComponent { get; }

		bool IsCurrentlySightable();
	}
}
