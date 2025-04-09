using UnityEngine;

namespace ScheduleOne.Trash
{
	public class TrashSpawnVolume : MonoBehaviour
	{
		public BoxCollider CreatonVolume;

		public BoxCollider DetectionVolume;

		public int TrashLimit;

		public float TrashSpawnChance;

		public void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SleepStart()
		{
		}
	}
}
