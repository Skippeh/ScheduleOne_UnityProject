namespace ScheduleOne.Packaging
{
	public class FunctionalJar : global::ScheduleOne.Packaging.FunctionalPackaging
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.PlayerTasks.Draggable Lid;

		public global::UnityEngine.Transform LidStartPoint;

		public global::UnityEngine.Collider LidSensor;

		public global::UnityEngine.Collider LidCollider;

		public global::UnityEngine.GameObject FullyPackedBlocker;

		private global::UnityEngine.GameObject LidObject;

		private global::UnityEngine.Vector3 lidPosition;

		public override global::ScheduleOne.PlayerScripts.CursorManager.ECursorType HoveredCursor { get; protected set; }

		public override void Initialize(global::ScheduleOne.ObjectScripts.PackagingStation _station, global::UnityEngine.Transform alignment, bool align = false)
		{
		}

		public override void Destroy()
		{
		}

		protected override void EnableSealing()
		{
		}

		protected override void LateUpdate()
		{
		}

		protected override void OnTriggerStay(global::UnityEngine.Collider other)
		{
		}

		public override void Seal()
		{
		}

		protected override void FullyPacked()
		{
		}
	}
}
