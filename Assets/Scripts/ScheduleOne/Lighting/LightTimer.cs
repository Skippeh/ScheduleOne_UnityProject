using ScheduleOne.Misc;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	[RequireComponent(typeof(ToggleableLight))]
	public class LightTimer : MonoBehaviour
	{
		[Header("Timing")]
		public int StartTime;

		public int EndTime;

		public int StartTimeOffset;

		private ToggleableLight toggleableLight;

		protected virtual void Awake()
		{
		}

		private void Start()
		{
		}

		protected virtual void UpdateState()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void SetState(bool on)
		{
		}
	}
}
