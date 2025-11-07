namespace ScheduleOne.UI
{
	public class QuestHUDUI : global::UnityEngine.MonoBehaviour
	{
		public string CriticalTimeColor;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform EntryContainer;

		public global::TMPro.TextMeshProUGUI MainLabel;

		public global::UnityEngine.UI.VerticalLayoutGroup hudUILayout;

		public global::UnityEngine.Animation Animation;

		public global::UnityEngine.RectTransform Shade;

		public global::System.Action onUpdateUI;

		public global::ScheduleOne.Quests.Quest Quest { get; private set; }

		public void Initialize(global::ScheduleOne.Quests.Quest quest)
		{
		}

		public void Destroy()
		{
		}

		public void UpdateUI()
		{
		}

		public void UpdateMainLabel()
		{
		}

		public void UpdateShade()
		{
		}

		public void BopIcon()
		{
		}

		private void FadeIn()
		{
		}

		private void EntryEnded(global::ScheduleOne.Quests.EQuestState endState)
		{
		}

		private void FadeOut()
		{
		}

		private void Complete()
		{
		}
	}
}
