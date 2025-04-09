using ScheduleOne.PlayerTasks;
using ScheduleOne.StationFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	public class Beaker : StationItem
	{
		public float ClampAngle_MaxLiquid;

		public float ClampAngle_MinLiquid;

		public float AngleToPour_MaxLiquid;

		public float AngleToPour_MinLiquid;

		[Header("References")]
		public Draggable Draggable;

		public DraggableConstraint Constraint;

		public Collider ConcaveCollider;

		public Collider ConvexCollider;

		public Transform CenterOfMass;

		public ConfigurableJoint Joint;

		public Rigidbody Anchor;

		public LiquidContainer Container;

		public Fillable Fillable;

		public PourableModule Pourable;

		public GameObject FilterPaper;

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
