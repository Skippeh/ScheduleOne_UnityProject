namespace ScheduleOne.Vision
{
	public class VisionEvent
	{
		private const float NOTICE_DROP_THRESHOLD = 1f;

		private float timeSinceSighted;

		private float currentNoticeTime;

		public global::ScheduleOne.PlayerScripts.Player Target { get; protected set; }

		public global::ScheduleOne.PlayerScripts.PlayerVisualState.VisualState State { get; protected set; }

		public global::ScheduleOne.Vision.VisionCone Owner { get; protected set; }

		public float FullNoticeTime { get; protected set; }

		public float NormalizedNoticeLevel => 0f;

		public VisionEvent(global::ScheduleOne.Vision.VisionCone _owner, global::ScheduleOne.PlayerScripts.Player _target, global::ScheduleOne.PlayerScripts.PlayerVisualState.VisualState _state, float _noticeTime)
		{
		}

		public void UpdateEvent(float visionDeltaThisFrame, float tickTime)
		{
		}

		public void EndEvent()
		{
		}
	}
}
