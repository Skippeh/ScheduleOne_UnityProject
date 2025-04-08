namespace ScheduleOne.Trash
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.BoxCollider))]
	public class TrashRemovalVolume : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.BoxCollider Collider;

		public float RemovalChance;

		public void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void SleepStart()
		{
		}

		private global::ScheduleOne.Trash.TrashItem[] GetTrash()
		{
			return null;
		}
	}
}
