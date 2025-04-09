using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	public class FunctionalBaggie : FunctionalPackaging
	{
		public SkinnedMeshRenderer[] BagMeshes;

		public GameObject FunnelCollidersContainer;

		public GameObject FullyPackedBlocker;

		public Collider DynamicCollider;

		private float ClosedDelta;

		public override CursorManager.ECursorType HoveredCursor { get; protected set; }

		public void SetClosed(float closedDelta)
		{
		}

		public override void StartClick(RaycastHit hit)
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
