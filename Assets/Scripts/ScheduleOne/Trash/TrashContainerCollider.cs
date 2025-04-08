namespace ScheduleOne.Trash
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class TrashContainerCollider : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Trash.TrashContainer Container;

		public void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}
	}
}
