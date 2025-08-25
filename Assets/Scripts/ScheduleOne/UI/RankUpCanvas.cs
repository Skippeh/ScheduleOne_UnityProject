namespace ScheduleOne.UI
{
	public class RankUpCanvas : global::UnityEngine.MonoBehaviour, global::ScheduleOne.UI.IPostSleepEvent
	{
		public global::UnityEngine.Animation OpenCloseAnim;

		public global::UnityEngine.Animation RankUpAnim;

		public global::TMPro.TextMeshProUGUI OldRankLabel;

		public global::TMPro.TextMeshProUGUI NewRankLabel;

		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.GameObject UnlockedItemsContainer;

		public global::UnityEngine.CanvasGroup UnlockedItemsCanvasGroup;

		public global::UnityEngine.RectTransform[] UnlockedItems;

		public global::TMPro.TextMeshProUGUI ExtraUnlocksLabel;

		public global::ScheduleOne.Audio.AudioSourceController SoundEffect;

		public global::UnityEngine.UI.Slider ProgressSlider;

		public global::TMPro.TextMeshProUGUI ProgressLabel;

		public global::ScheduleOne.Audio.AudioSourceController BlipSound;

		public global::ScheduleOne.Audio.AudioSourceController ClickSound;

		private global::UnityEngine.Coroutine coroutine;

		private global::System.Collections.Generic.List<global::System.Tuple<global::ScheduleOne.Levelling.FullRank, global::ScheduleOne.Levelling.FullRank>> queuedRankUps;

		public bool IsRunning { get; private set; }

		public int Order { get; private set; }

		public void Start()
		{
		}

		private void QueuePostSleepEvent()
		{
		}

		public void StartEvent()
		{
		}

		public void EndEvent()
		{
		}

		public void RankUp(global::ScheduleOne.Levelling.FullRank oldRank, global::ScheduleOne.Levelling.FullRank newRank)
		{
		}

		private void PlayRankupAnimation(global::ScheduleOne.Levelling.FullRank oldRank, global::ScheduleOne.Levelling.FullRank newRank, bool playSound)
		{
		}
	}
}
