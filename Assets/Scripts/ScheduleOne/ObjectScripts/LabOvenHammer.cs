namespace ScheduleOne.ObjectScripts
{
	public class LabOvenHammer : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.PlayerTasks.Draggable Draggable;

		public global::ScheduleOne.PlayerTasks.DraggableConstraint Constraint;

		public global::ScheduleOne.PlayerTasks.RotateRigidbodyToTarget Rotator;

		public global::UnityEngine.Transform CoM;

		public global::UnityEngine.Transform ImpactPoint;

		public global::ScheduleOne.Tools.SmoothedVelocityCalculator VelocityCalculator;

		[global::UnityEngine.Header("Settings")]
		public float MinHeight;

		public float MaxHeight;

		public float MinAngle;

		public float MaxAngle;

		public global::UnityEngine.Events.UnityEvent<global::UnityEngine.Collision> onCollision;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnCollisionEnter(global::UnityEngine.Collision collision)
		{
		}
	}
}
