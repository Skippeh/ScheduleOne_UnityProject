namespace ScheduleOne.Packaging
{
	public class FunctionalBaggie : global::ScheduleOne.Packaging.FunctionalPackaging
	{
		public global::UnityEngine.SkinnedMeshRenderer[] BagMeshes;

		public global::UnityEngine.GameObject FunnelCollidersContainer;

		public global::UnityEngine.GameObject FullyPackedBlocker;

		public global::UnityEngine.Collider DynamicCollider;

		private float ClosedDelta;

		public override global::ScheduleOne.PlayerScripts.CursorManager.ECursorType HoveredCursor { get; protected set; }

		public void SetClosed(float closedDelta)
		{
		}

		public override void StartClick(global::UnityEngine.RaycastHit hit)
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
