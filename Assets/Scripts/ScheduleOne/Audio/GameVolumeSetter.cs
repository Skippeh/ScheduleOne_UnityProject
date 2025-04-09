using UnityEngine;

namespace ScheduleOne.Audio
{
	public class GameVolumeSetter : MonoBehaviour
	{
		[Range(0f, 1f)]
		public float VolumeMultiplier;

		private void Update()
		{
		}
	}
}
