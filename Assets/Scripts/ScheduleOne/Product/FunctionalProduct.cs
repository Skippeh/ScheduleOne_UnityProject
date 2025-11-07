namespace ScheduleOne.Product
{
	public class FunctionalProduct : global::ScheduleOne.PlayerTasks.Draggable
	{
		public bool ClampZ;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform AlignmentPoint;

		public global::ScheduleOne.Product.ProductVisualsSetter Visuals;

		private global::UnityEngine.Vector3 startLocalPos;

		private float lowestMaxZ;

		public global::ScheduleOne.Tools.SmoothedVelocityCalculator VelocityCalculator { get; private set; }

		public virtual void Initialize(global::ScheduleOne.ObjectScripts.PackagingStation station, global::ScheduleOne.ItemFramework.ItemInstance item, global::UnityEngine.Transform alignment, bool align = true)
		{
		}

		public virtual void Initialize(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public virtual void InitializeVisuals(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public void AlignTo(global::UnityEngine.Transform alignment)
		{
		}

		protected override void FixedUpdate()
		{
		}

		protected override void LateUpdate()
		{
		}

		private void Clamp()
		{
		}
	}
}
