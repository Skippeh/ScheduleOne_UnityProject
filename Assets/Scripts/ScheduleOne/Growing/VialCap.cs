namespace ScheduleOne.Growing
{
	public class VialCap : global::ScheduleOne.PlayerTasks.Clickable
	{
		public global::UnityEngine.Collider Collider;

		private global::UnityEngine.Rigidbody RigidBody;

		public bool Removed { get; protected set; }

		public override void StartClick(global::UnityEngine.RaycastHit hit)
		{
		}

		private void Pop()
		{
		}
	}
}
