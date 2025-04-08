namespace ScheduleOne.GameTime
{
	public class AnalogueClock : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Transform MinHand;

		public global::UnityEngine.Transform HourHand;

		public global::UnityEngine.Vector3 RotationAxis;

		public global::UnityEngine.Events.UnityEvent onNoon;

		public global::UnityEngine.Events.UnityEvent onMidnight;

		public void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void MinPass()
		{
		}
	}
}
