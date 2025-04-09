using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	public class FunctionalProduct : Draggable
	{
		public bool ClampZ;

		[Header("References")]
		public Transform AlignmentPoint;

		public FilledPackagingVisuals Visuals;

		private Vector3 startLocalPos;

		private float lowestMaxZ;

		public SmoothedVelocityCalculator VelocityCalculator { get; private set; }

		public virtual void Initialize(PackagingStation station, ItemInstance item, Transform alignment, bool align = true)
		{
		}

		public virtual void Initialize(ItemInstance item)
		{
		}

		public virtual void InitializeVisuals(ItemInstance item)
		{
		}

		public void AlignTo(Transform alignment)
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
