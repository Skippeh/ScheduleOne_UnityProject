namespace ScheduleOne.StationFramework
{
	public class PourableAngleLimit : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.StationFramework.PourableModule Pourable;

		public global::ScheduleOne.PlayerTasks.DraggableConstraint Constraint;

		[global::UnityEngine.Header("Settings")]
		public float AngleAtMaxFill;

		public float AngleAtMinFill;

		public float PourAngleMaxFill;

		public float PourAngleMinFill;

		private void Awake()
		{
		}

		public void FixedUpdate()
		{
		}
	}
}
