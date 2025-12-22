namespace ScheduleOne.PlayerTasks
{
	public class Sprayable : global::ScheduleOne.PlayerTasks.Draggable
	{
		[global::UnityEngine.Header("Sprayable Components")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _sprayOrigin;

		[global::UnityEngine.Header("Gizmos")]
		[global::UnityEngine.SerializeField]
		private bool _drawGizmos;

		public global::System.Action _onSuccessfulSpray;

		public global::UnityEngine.Events.UnityEvent onSpray;

		private float _sprayRadius;

		private float _sprayDistance;

		private global::UnityEngine.Vector3 _currentTargetPosition;

		public void Initialise(float sprayRadius, float sprayDistance)
		{
		}

		protected override void Update()
		{
		}

		private void Spray()
		{
		}

		public void SetCurrentTarget(global::UnityEngine.Vector3 position)
		{
		}

		private bool DoesHitTarget(global::UnityEngine.Vector3 rayOrigin, global::UnityEngine.Vector3 rayDirection, global::UnityEngine.Vector3 sphereCenter, float sphereRadius, float maxDistance)
		{
			return false;
		}

		public void SubscribeToSuccessfulSpray(global::System.Action callback)
		{
		}

		public void UnsubscribeFromSuccessfulSpray(global::System.Action callback)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
