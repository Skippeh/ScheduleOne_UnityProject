namespace ScheduleOne.PlayerTasks
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.PlayerTasks.Clickable))]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class SpawnChunk : global::ScheduleOne.PlayerTasks.Clickable
	{
		private global::UnityEngine.MeshRenderer _meshRenderer;

		private global::UnityEngine.Rigidbody _rb;

		private global::UnityEngine.Collider _collider;

		private bool _isBroken;

		private global::System.Collections.Generic.List<global::ScheduleOne.PlayerTasks.SpawnChunk> _childChunks;

		public global::UnityEngine.Events.UnityEvent OnBreak;

		private bool hasChildChunks => false;

		private void Awake()
		{
		}

		public void EnableChunk(global::UnityEngine.Vector3 force, global::UnityEngine.Vector3 torque)
		{
		}

		public void DisableChunk(bool recursive)
		{
		}

		public void Break()
		{
		}

		public bool GetIsBroken(bool recursive = true)
		{
			return false;
		}

		public override void StartClick(global::UnityEngine.RaycastHit hit)
		{
		}

		public void SetChunkOrder(int i)
		{
		}
	}
}
