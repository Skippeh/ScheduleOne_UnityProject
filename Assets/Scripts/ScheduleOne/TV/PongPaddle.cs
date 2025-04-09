using UnityEngine;

namespace ScheduleOne.TV
{
	public class PongPaddle : MonoBehaviour
	{
		public const float BOUND_Y = 160f;

		public const float MOVE_SPEED = 20f;

		public float SpeedMultiplier;

		public RectTransform Rect;

		public float TargetY { get; set; }

		public void SetTargetY(float y)
		{
		}

		private void Update()
		{
		}

		private void UpdateMove()
		{
		}
	}
}
