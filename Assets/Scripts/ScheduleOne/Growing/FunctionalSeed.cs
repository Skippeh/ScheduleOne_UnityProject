namespace ScheduleOne.Growing
{
	public class FunctionalSeed : global::UnityEngine.MonoBehaviour
	{
		public global::System.Action onSeedExitVial;

		public global::ScheduleOne.PlayerTasks.Draggable Vial;

		public global::UnityEngine.Collider SeedBlocker;

		public global::ScheduleOne.Growing.VialCap Cap;

		public global::UnityEngine.Collider SeedCollider;

		public global::UnityEngine.Rigidbody SeedRigidbody;

		public global::ScheduleOne.Trash.TrashItem TrashPrefab;

		public void TriggerExit(global::UnityEngine.Collider other)
		{
		}
	}
}
