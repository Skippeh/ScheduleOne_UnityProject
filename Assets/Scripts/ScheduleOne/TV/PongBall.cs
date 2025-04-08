namespace ScheduleOne.TV
{
	public class PongBall : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.TV.Pong Game;

		public global::UnityEngine.RectTransform Rect;

		public global::UnityEngine.Rigidbody RB;

		public float RandomForce;

		public global::UnityEngine.Events.UnityEvent onHit;

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter(global::UnityEngine.Collision collision)
		{
		}
	}
}
