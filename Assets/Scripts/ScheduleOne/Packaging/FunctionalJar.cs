using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	public class FunctionalJar : FunctionalPackaging
	{
		[Header("References")]
		public Draggable Lid;

		public Transform LidStartPoint;

		public Collider LidSensor;

		public Collider LidCollider;

		public GameObject FullyPackedBlocker;

		private GameObject LidObject;

		private Vector3 lidPosition;

		public override CursorManager.ECursorType HoveredCursor { get; protected set; }

		public override void Initialize(PackagingStation _station, Transform alignment, bool align = false)
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

		protected override void OnTriggerStay(Collider other)
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
