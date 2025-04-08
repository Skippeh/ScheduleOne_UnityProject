namespace ScheduleOne.UI
{
	public class RegionUnlockedCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.RegionUnlockedCanvas>, global::ScheduleOne.UI.IPostSleepEvent
	{
		public global::UnityEngine.Animation OpenCloseAnim;

		public global::TMPro.TextMeshProUGUI RegionLabel;

		public global::TMPro.TextMeshProUGUI RegionDescription;

		public global::UnityEngine.UI.Image RegionImage;

		private global::ScheduleOne.Map.EMapRegion region;

		public bool IsRunning { get; private set; }

		public int Order { get; private set; }

		public void QueueUnlocked(global::ScheduleOne.Map.EMapRegion _region)
		{
		}

		public void StartEvent()
		{
		}

		public void EndEvent()
		{
		}
	}
}
