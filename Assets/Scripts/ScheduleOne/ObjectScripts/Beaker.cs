namespace ScheduleOne.ObjectScripts
{
	public class Beaker : global::ScheduleOne.StationFramework.StationItem
	{
		public float ClampAngle_MaxLiquid;

		public float ClampAngle_MinLiquid;

		public float AngleToPour_MaxLiquid;

		public float AngleToPour_MinLiquid;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.PlayerTasks.Draggable Draggable;

		public global::ScheduleOne.PlayerTasks.DraggableConstraint Constraint;

		public global::UnityEngine.Collider ConcaveCollider;

		public global::UnityEngine.Collider ConvexCollider;

		public global::UnityEngine.Transform CenterOfMass;

		public global::UnityEngine.ConfigurableJoint Joint;

		public global::UnityEngine.Rigidbody Anchor;

		public global::ScheduleOne.StationFramework.LiquidContainer Container;

		public global::ScheduleOne.StationFramework.Fillable Fillable;

		public global::ScheduleOne.StationFramework.PourableModule Pourable;

		public global::UnityEngine.GameObject FilterPaper;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SetStatic(bool stat)
		{
		}
	}
}
