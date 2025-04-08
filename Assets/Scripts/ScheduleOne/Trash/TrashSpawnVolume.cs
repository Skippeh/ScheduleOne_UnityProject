namespace ScheduleOne.Trash
{
	public class TrashSpawnVolume : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.BoxCollider CreatonVolume;

		public global::UnityEngine.BoxCollider DetectionVolume;

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
