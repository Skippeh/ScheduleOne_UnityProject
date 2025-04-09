using EasyButtons;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	public class DelayedUnityEvent : MonoBehaviour
	{
		public float Delay;

		public UnityEvent onDelayStart;

		public UnityEvent onDelayedExecute;

		[Button]
		public void Execute()
		{
		}
	}
}
