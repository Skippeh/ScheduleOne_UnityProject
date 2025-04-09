using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	public class PongBall : MonoBehaviour
	{
		public Pong Game;

		public RectTransform Rect;

		public Rigidbody RB;

		public float RandomForce;

		public UnityEvent onHit;

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
