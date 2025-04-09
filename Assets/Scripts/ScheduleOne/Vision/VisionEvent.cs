using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Vision
{
	public class VisionEvent
	{
		private const float NOTICE_DROP_THRESHOLD = 1f;

		private float timeSinceSighted;

		private float currentNoticeTime;

		public Player Target { get; protected set; }

		public PlayerVisualState.VisualState State { get; protected set; }

		public VisionCone Owner { get; protected set; }

		public float FullNoticeTime { get; protected set; }

		public float NormalizedNoticeLevel => 0f;

		public VisionEvent(VisionCone _owner, Player _target, PlayerVisualState.VisualState _state, float _noticeTime)
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
