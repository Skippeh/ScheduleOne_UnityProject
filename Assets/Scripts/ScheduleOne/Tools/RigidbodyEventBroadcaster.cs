using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	public class RigidbodyEventBroadcaster : MonoBehaviour
	{
		public UnityEvent<Collider> onTriggerEnter;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
