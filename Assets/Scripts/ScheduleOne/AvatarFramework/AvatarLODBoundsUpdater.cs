namespace ScheduleOne.AvatarFramework
{
	public class AvatarLODBoundsUpdater : global::UnityEngine.MonoBehaviour
	{
		public const float CHECK_RATE_SECONDS = 1f;

		public const float HIP_OFFSET_THRESHOLD = 5f;

		public global::ScheduleOne.AvatarFramework.Avatar Avatar;

		private global::System.Collections.Generic.List<global::UnityEngine.LODGroup> lodGroups;

		private global::UnityEngine.Vector3 hipOffsetOnLastRefresh;

		private void Awake()
		{
		}

		private void InfrequentUpdate()
		{
		}

		private void GetLODGroups()
		{
		}

		private void Recalculate()
		{
		}
	}
}
