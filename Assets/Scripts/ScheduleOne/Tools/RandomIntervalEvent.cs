using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	public class RandomIntervalEvent : MonoBehaviour
	{
		public float MinInterval;

		public float MaxInterval;

		public bool ExecuteOnEnable;

		public UnityEvent OnInterval;

		private float nextInterval;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void Execute()
		{
		}
	}
}
