using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	public class LoadEventTransmitter : MonoBehaviour
	{
		public UnityEvent onLoadComplete;

		private void Start()
		{
		}

		private void OnLoadComplete()
		{
		}
	}
}
