using UnityEngine;

namespace ScheduleOne.Trash
{
	[RequireComponent(typeof(Rigidbody))]
	public class TrashContainerCollider : MonoBehaviour
	{
		public TrashContainer Container;

		public void OnTriggerEnter(Collider other)
		{
		}
	}
}
