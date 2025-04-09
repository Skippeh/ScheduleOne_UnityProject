using UnityEngine;

namespace ScheduleOne.UI
{
	public class SlidingRect : MonoBehaviour
	{
		public RectTransform Rect;

		public Vector2 Start;

		public Vector2 End;

		public float Duration;

		public float SpeedMultiplier;

		private float _time;

		public void Update()
		{
		}
	}
}
