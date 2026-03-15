namespace ScheduleOne.PlayerScripts
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.PlayerScripts.PlayerMovement))]
	public class LocalPlayerFootstepGenerator : global::ScheduleOne.Tools.GenericFootstepDetector
	{
		private const float DistancePerStep = 1.25f;

		private global::ScheduleOne.PlayerScripts.PlayerMovement _movement;

		private float _currentDistance;

		private global::UnityEngine.Vector3 _lastFramePosition;

		private void Awake()
		{
		}

		protected void LateUpdate()
		{
		}
	}
}
