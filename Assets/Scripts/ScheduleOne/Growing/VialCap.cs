using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	public class VialCap : Clickable
	{
		public Collider Collider;

		private Rigidbody RigidBody;

		public bool Removed { get; protected set; }

		public override void StartClick(RaycastHit hit)
		{
		}

		private void Pop()
		{
		}
	}
}
